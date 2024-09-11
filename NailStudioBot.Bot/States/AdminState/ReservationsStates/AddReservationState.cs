using NailStudioBot.Bot.States.AdminState.MasterOperationStates;
using NailStudioBot.Bot.Statettes;
using NailStudioBot.Core.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailStudioBot.Bot.States.AdminState.ReservationsStates
{
    public class AddReservationState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            var reservation = new ReservationsInputModel();

            //if (DateTime.TryParse(update.Message.Text, out DateTime startDateTime))
            //{
            //    reservation.StartDateTime = startDateTime.ToString(); 
            //    context.State = new AddMasterPhone(reservation);
            //}
            //else
            //{

            //    context.BotClient.SendTextMessageAsync("Пожалуйста, введите корректную дату и время в формате (например, 2023-10-10 14:00).");
            //}
        }
        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            botClient.SendTextMessageAsync(context.ChatId, "Введите дату и время записи");
        }
    }

    }

