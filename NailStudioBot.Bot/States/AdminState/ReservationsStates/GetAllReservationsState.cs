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

            //var reservations = new ReservationsServices().GetAllReservations();

            //string res = "";

            //foreach (var reservation in reservations)
            //{
            //    res += $"{reservations.StartDateTime}-{reservations.Name}-{reservations.Cost}\n";
            //}

            //botClient.SendTextMessageAsync(new ChatId(context.ChatId), res);

            //context.State = new MasterMenuState();

        }

        InlineKeyboardMarkup markup = new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                        new InlineKeyboardButton[]
                        {
                            new InlineKeyboardButton("Вернутся в меню") { CallbackData="1"},

                        },

                }
                );

    }
}

