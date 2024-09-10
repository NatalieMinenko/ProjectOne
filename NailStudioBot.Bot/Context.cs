using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using NailStudioBot.Bot.Statettes;
using NailStudioBot.Bot.States;

namespace NailStudioBot.Bot
{
    public class Context
    {
        public ITelegramBotClient BotClient { get; set; }
        public long ChatId { get; set; }
        public AbstractState State { get; set; }


        public void HandleMessage(Update update)
        {
            State.HandleMessage(this, update);
        }

        public void ReactInBot(ITelegramBotClient botClient)
        {
            State.ReactInBot(this, botClient);
        }
    }
}


