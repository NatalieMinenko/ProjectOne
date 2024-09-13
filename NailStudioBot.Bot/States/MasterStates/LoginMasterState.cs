using NailStudioBot.Bot.States.AdminState;
using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;
using NailStudioBot.BLL;

namespace NailStudioBot.Bot.States.MasterStates
{
    public class LoginMasterState : AbstractState
    {
        private string MasterPassword = "222";
        public override void HandleMessage(Context context, Update update)
        {
            if (update.Type == UpdateType.Message)
            {
                var message = update.Message;

                if (message.Text.ToLower() == MasterPassword)
                {
                    context.State = new MasterIdState();
                }
                else
                {
                    context.State = new LoginMasterState();
                }
            }
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            botClient.SendTextMessageAsync(new ChatId(context.ChatId), "Введите пароль");
        }
    }
}
