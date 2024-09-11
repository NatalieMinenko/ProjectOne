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

namespace NailStudioBot.Bot.States.AdminState.ServicesOperationsStates
{
    public class AddServicesDurationState : AbstractState
    {
        private ServicesServices _servicesServices;

        private ServicesInputModel _servicesInputModel;

        public AddServicesDurationState(ServicesInputModel servicesModel)
        {
            _servicesInputModel = servicesModel;
            _servicesServices = new ServicesServices();
        }
        public override void HandleMessage(Context context, Update update)
        {
            _servicesInputModel.Duration = update.Message.Text;
            _servicesServices.AddService(_servicesInputModel);
            context.State = new AdminMenuState();
        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            var sent = botClient.SendTextMessageAsync(context.ChatId, "Введите продолжитльность услуги");
        }
    }
}
