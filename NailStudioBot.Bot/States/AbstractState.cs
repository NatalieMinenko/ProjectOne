using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace NailStudioBot.Bot.Statettes
{
    public abstract class AbstractState
    {
        public abstract void HandleMessage(Context context, Update update);

        public abstract void ReactInBot(Context context, ITelegramBotClient botClient);
    }
}
