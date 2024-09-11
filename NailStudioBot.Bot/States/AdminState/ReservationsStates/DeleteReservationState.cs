using NailStudioBot.BLL;
using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailStudioBot.Bot.States.AdminState.ReservationsStates
{
    public class DeleteReservationState : AbstractState
    {
        private ReservationsServices _reservationsServices;
        public DeleteReservationState()
        {
            _reservationsServices = new ReservationsServices();
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
