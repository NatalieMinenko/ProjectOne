using NailStudioBot.Bot.States.AdminState.MasterOperationStates;
using NailStudioBot.Bot.States.AdminState.ServicesOperationsStates;
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
    public class AdminServicesState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            if (update.CallbackQuery.Data == "1")
            {
                context.State = new AddServicesState();
            }
            else if (update.CallbackQuery.Data == "2")
            {

                context.State = new DeleteServicesState();
            }
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            InlineKeyboardMarkup markup = new InlineKeyboardMarkup(

                        new InlineKeyboardButton[]
                        {
                            new InlineKeyboardButton("Добавить услугу") { CallbackData="1"},
                            new InlineKeyboardButton("Удалить услугу") { CallbackData="2"},
                        }

                  );

            var sent = botClient.SendTextMessageAsync(context.ChatId, "Choose a response", replyMarkup: markup);

        }
    }
}
