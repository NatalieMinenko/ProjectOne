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

namespace NailStudioBot.Bot.States.AdminState
{
    public class AdminMenuState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            if (update.CallbackQuery.Data == "1")
            {
                context.State = new AdminMasterState();
            }
            else if (update.CallbackQuery.Data == "2")
            {

                context.State = new AdminServicesState();
            }
            else if (update.CallbackQuery.Data == "3")
            {
                context.State = new AdminReservationsState();
            }
       
            //return replyState;
        }
        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            // using Telegram.Bot.Types.ReplyMarkups;

            InlineKeyboardMarkup markup = new InlineKeyboardMarkup(
                   new InlineKeyboardButton[][]
                   {
                        new InlineKeyboardButton[]
                        {
                            new InlineKeyboardButton("Работа с мастерами") { CallbackData="1"},
                            new InlineKeyboardButton("Работа с услугами") { CallbackData="2"},
                        },
                        new InlineKeyboardButton[]
                        {
                            new InlineKeyboardButton("Работа с записями") { CallbackData="3"},
      
                        }
                   }
                   );

            var sent = botClient.SendTextMessageAsync(context.ChatId, "Choose a response", replyMarkup: markup);

        }
    }

    }

