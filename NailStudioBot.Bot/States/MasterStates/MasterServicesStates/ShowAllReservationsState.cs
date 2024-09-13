using NailStudioBot.BLL;
using NailStudioBot.Bot.States.AdminState;
using NailStudioBot.Bot.Statettes;
using NailStudioBot.Core.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace NailStudioBot.Bot.States.MasterStates.MasterServicesStates
{
    public class ShowAllReservationsState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            if (update.CallbackQuery.Data == "1")
            {
                context.State = new MasterMenuState();
            }
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            var reservations = new ReservationsServices().GetAllReservations();

            StringBuilder res = new StringBuilder();

            foreach (var reservation in reservations)
            {
                res.AppendLine($"{reservation.StartDateTime} - {reservation.Sum} - {reservation.ClientId}\n");
            }

            if (res.Length == 0)
            {
                res.Append("Нет доступных записей");
            }

            var markup = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("Вернуться в меню", "1")
                }
            });

            botClient.SendTextMessageAsync(new ChatId(context.ChatId), res.ToString(), replyMarkup: markup);

        }
    }
}
