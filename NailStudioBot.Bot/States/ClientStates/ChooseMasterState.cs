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
using NailStudioBot.BLL;
using NailStudio.DAL;
using NailStudioBot.Core.OutPutModels;
using NailStudio.DAL.Querys;

namespace NailStudioBot.Bot.States.ClientStates
{
    public class ChooseMasterState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            throw new NotImplementedException();
        }

        public override async void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            throw new NotImplementedException();
        }
                 
    }
}
