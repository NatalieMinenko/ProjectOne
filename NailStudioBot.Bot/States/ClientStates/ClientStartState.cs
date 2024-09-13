using NailStudioBot.Bot.States.AdminState.MasterOperationStates;
using NailStudioBot.Bot.States.AdminState.ReservationsStates;
using NailStudioBot.Bot.States.AdminState;
using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace NailStudioBot.Bot.States.ClientStates
{
    public class ClientStartState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            if (update.CallbackQuery == null)
            {
                context.State = new AdminMenuState();
                return;
            }

            if (update.CallbackQuery.Data == "1")
            {
                context.State = new ChooseMasterState();
            }
            else if (update.CallbackQuery.Data == "2")
            {

                context.State = new ChooseServiceState();
            }
            else if (update.CallbackQuery.Data == "3")
            {
                context.State = new GetAllReservationsState();
            }
            else if (update.CallbackQuery.Data == "4")
            {
                context.State = new ChooseDateTimeState();
            }
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
        InlineKeyboardMarkup markup = new InlineKeyboardMarkup(
             new InlineKeyboardButton[][]
             {
                   new InlineKeyboardButton[]
                   {
                   new InlineKeyboardButton("Выбрать мастера") { CallbackData="1"},
                   new InlineKeyboardButton("Выберать услугу") { CallbackData="2"},
                   
                   },
                   new InlineKeyboardButton[]
                   {
                   new InlineKeyboardButton("Просмотреть имеющиеся записи") { CallbackData="3"},
                   new InlineKeyboardButton("Выберать дату/время") { CallbackData="4"},
                   }
             }
             );

            var sent = botClient.SendTextMessageAsync(context.ChatId, "Выберите действие", replyMarkup: markup);
        }
    }
}

