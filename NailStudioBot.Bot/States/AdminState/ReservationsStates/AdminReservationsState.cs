using NailStudioBot.Bot.States.AdminState.MasterOperationStates;
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
    public class AdminReservationsState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            switch (update.CallbackQuery.Data)
            {
                case "1":
                    context.State = new UpdateResetvationState();
                    break;
                case "2":
                    context.State = new AddReservationState();
                    break;
                case "3":
                    context.State = new DeleteReservationState();
                    break;
                case "4":
                    context.State = new GetAllReservationsState();
                    break;
                case "5":
                    context.State = new AdminMenuState();
                    break;
                default:
                    break;
            }


        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {


            // using Telegram.Bot.Types.ReplyMarkups;

            InlineKeyboardMarkup markup = new InlineKeyboardMarkup(
                   new InlineKeyboardButton[][]
                   {
                        new InlineKeyboardButton[]
                        {
                            new InlineKeyboardButton("Редактировать запись") { CallbackData="1"},
                            new InlineKeyboardButton("Добавить запись") { CallbackData="2"},
                             new InlineKeyboardButton("Удалить запись") { CallbackData="3"},
                        },
                        new InlineKeyboardButton[]
                        {
                            new InlineKeyboardButton("Посмотреть все записи") { CallbackData="4"},
                            new InlineKeyboardButton("Вернуться в меню") { CallbackData="5"},


                        }
                   }
                   );

            var sent = botClient.SendTextMessageAsync(context.ChatId, "Choose a response", replyMarkup: markup);


        }
    }
}
