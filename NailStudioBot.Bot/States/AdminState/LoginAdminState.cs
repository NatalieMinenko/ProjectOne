using NailStudioBot.Bot.States.AdminState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace NailStudioBot.Bot.Statettes.AdmonState
{
    public class LoginAdminState : AbstractState
    {
        private  string AdminPassword = "111";
        public override void HandleMessage(Context context, Update update)
        {
            if (update.Type == UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == AdminPassword)
                {
                    context.State = new AdminMenuState();
                }
                else 
                {
                    context.State = new LoginAdminState();
                }

                
            }
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
                 botClient.SendTextMessageAsync(new ChatId(context.ChatId), "Введите пароль");

        }
    }
}
