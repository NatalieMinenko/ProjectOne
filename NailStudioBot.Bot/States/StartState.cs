using NailStudioBot.Bot.States.ClientStates;
using NailStudioBot.Bot.States.MasterStates;
using NailStudioBot.Bot.Statettes;
using NailStudioBot.Bot.Statettes.AdmonState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailStudioBot.Bot.States
{
    public class StartState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            if (update.Message?.Text != null)
            {
                switch (update.Message.Text.ToLower())
                {
                    case "/start":
                        context.State = new ClientStartState();
                        break;
                    case "/admin":
                        context.State = new LoginAdminState();
                        break;
                    case "/master":
                        context.State = new LoginMasterState();
                        break;
                    default:

                        break;
                }
            }
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            botClient.SendTextMessageAsync(new ChatId(context.ChatId), "Добро пожаловать в салон Ноготочки в стиле IT введите /start");
        }
    }
    }

