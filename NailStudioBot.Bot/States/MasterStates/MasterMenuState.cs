using NailStudioBot.Bot.States.MasterStates.MasterServicesStates;
using NailStudioBot.Bot.States.AdminState;
using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using NailStudioBot.Bot.States.AdminState.MasterOperationStates;
using NailStudioBot.Bot.States.AdminState.ReservationsStates;
using NailStudioBot.BLL;
using NailStudioBot.Core.InputModels;
using NailStudioBot.Core.OutPutModels;
using System.Reflection.Metadata.Ecma335;

namespace NailStudioBot.Bot.States.MasterStates
{
    public class MasterMenuState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            if (update.CallbackQuery == null)
            {
                context.State = new MasterIdState();
                return;
            }

            if (update.CallbackQuery.Data == "1")
            {
                context.State = new ShowActiveReservationsState();
            }
            else if (update.CallbackQuery.Data == "2")
            {
                context.State = new ShowAllReservationsState();
            }
            
        }
        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            InlineKeyboardMarkup markup = new InlineKeyboardMarkup(

                   new InlineKeyboardButton[][]
                   {
                        new InlineKeyboardButton[]
                        {
                            new InlineKeyboardButton("Активные записи") { CallbackData="1"},
                            new InlineKeyboardButton("Все записи") { CallbackData="2"},
                        }
                   }
                   );

            var sent = botClient.SendTextMessageAsync(context.ChatId, "Choose a response", replyMarkup: markup);
        }
    }
}

