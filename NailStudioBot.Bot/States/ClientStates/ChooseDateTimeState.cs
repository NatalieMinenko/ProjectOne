﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using NailStudioBot.Bot.Statettes;

namespace NailStudioBot.Bot.States.ClientStates
{
    public class ChooseDateTimeState : AbstractState
    {
        public ChooseDateTimeState(int id) 
        {
            var c = id;
        }
        public override void HandleMessage(Context context, Update update)
        {
            throw new NotImplementedException();
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            throw new NotImplementedException();
        }
    }
}
