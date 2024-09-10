using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace NailStudioBot.Bot.States.AdminState.MasterOperationStates
{
    public class AdminMasterState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            if (update.CallbackQuery.Data == "1")
            {
                context.State = new AddMasterNameState();
            }
            else if (update.CallbackQuery.Data == "2")
            {

                context.State = new DeleteMasterState();
            }
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            InlineKeyboardMarkup markup = new InlineKeyboardMarkup(

                        new InlineKeyboardButton[]
                        {
                            new InlineKeyboardButton("Добавить мастера") { CallbackData="1"},
                            new InlineKeyboardButton("Удалить мастера") { CallbackData="2"},
                        }

                  );

            var sent = botClient.SendTextMessageAsync(context.ChatId, "Choose a response", replyMarkup: markup);

        }
    }
}

