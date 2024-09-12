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
            if (int.TryParse(update.Message.Text, out int id))
            {
                if (_reservationsServices.ReservationExist(id))
                {
                    _reservationsServices.DeleteReservation(id);
                    context.BotClient.SendTextMessageAsync(context.ChatId, $"Пользователь с ID {id} был успешно удалён.");
                }
                else
                {
                    context.BotClient.SendTextMessageAsync(context.ChatId, $"Пользователь с ID {id} не найден.");
                }
            }
            else
            {
                context.BotClient.SendTextMessageAsync(context.ChatId, "Пожалуйста, введите корректный ID пользователя.");
            }

            context.State = new AdminMenuState();
        }
        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            botClient.SendTextMessageAsync(context.ChatId, "Введите Id записи, которую хотите удалить");
        }

    }
}

