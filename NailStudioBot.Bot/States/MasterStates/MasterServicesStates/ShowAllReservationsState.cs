using NailStudioBot.BLL;
using NailStudioBot.Bot.Statettes;
using NailStudioBot.Core.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailStudioBot.Bot.States.MasterStates.MasterServicesStates
{
    public class ShowAllReservationsState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            
        }

        public override async void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            var reservations = new ReservationsServices().GetAllReservations();

            string res = "";

            foreach (var reservation in reservations)
            {
                res += $"{reservations.Id}-{reservations.Name}-{reservations.Cost}\n";
            }

            await botClient.SendTextMessageAsync(new ChatId(context.ChatId), res);

            context.State = new MasterMenuState();
        }
    }
}
