using NailStudioBot.BLL;
using NailStudioBot.Bot.States.AdminState.MasterOperationStates;
using NailStudioBot.Bot.States.MasterStates;
using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace NailStudioBot.Bot.States.AdminState.ReservationsStates
{
    public class GetAllReservationsState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            if (update.CallbackQuery.Data == "1")
            {
                context.State = new AdminMenuState();
            }


        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            var reservations = new ReservationsServices().GetAllReservations();
            StringBuilder res = new StringBuilder();

            // Формируем сообщение о всех резервированиях
            foreach (var reservation in reservations)
            {
                res.AppendLine($"{reservation.StartDateTime} - {reservation.Sum} - {reservation.ClientId}");
            }

            // Проверяем, пуст ли результат
            if (res.Length == 0)
            {
                res.Append("Нет доступных резервирований.");
            }

            var markup = new InlineKeyboardMarkup(new[]
            {
                new[] // первая строка кнопок
                {
                    InlineKeyboardButton.WithCallbackData("Вернуться в меню", "1")                         // Маппинг не работает
                }
            });



            botClient.SendTextMessageAsync(new ChatId(context.ChatId), res.ToString(), replyMarkup: markup);




        }
    }
}

