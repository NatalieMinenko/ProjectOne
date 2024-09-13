using NailStudioBot.BLL;
using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailStudioBot.Bot.States.AdminState.ServicesOperationsStates
{
    public class DeleteServicesState : AbstractState
    {
        private ServicesServices _servicesServices;
        public DeleteServicesState()
        {
            _servicesServices = new ServicesServices();
        }
        public override void HandleMessage(Context context, Update update)
        {
            if (int.TryParse(update.Message.Text, out int serviceId))
            {
                // Проверяем, существует ли услуга с данным ID
                if (_servicesServices.ServicesExists(serviceId))
                {
                    // Удаляем услугу
                    _servicesServices.DeleteService(serviceId);
                    context.BotClient.SendTextMessageAsync(context.ChatId,
                        $"Услуга с ID {serviceId} была успешно удалена."); // Тут должно быть новое состояние
                }
                else
                {
                    context.BotClient.SendTextMessageAsync(context.ChatId,
                        $"Услуга с ID {serviceId} не найдена.");
                }
            }
                else
                {
                    // Если введенный ID не верный
                    context.BotClient.SendTextMessageAsync(context.ChatId,
                        "Пожалуйста, введите корректный ID услуги для удаления.");
                }
            context.State = new AdminMenuState();
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            botClient.SendTextMessageAsync(context.ChatId,"Введите ID услуги, которую хотите удалить:");
        }
    }
}
