using NailStudioBot.BLL;
using NailStudioBot.Bot.States.AdminState.ServicesOperationsStates;
using NailStudioBot.Bot.Statettes;
using NailStudioBot.Core.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace NailStudioBot.Bot.States.ClientStates
{
    public class ChooseServiceState : AbstractState
    {
        private ServicesServices _servicesServices;


        public ChooseServiceState ()
        {
            _servicesServices = new ServicesServices();
        }
        public override void HandleMessage(Context context, Update update)
        {

            int.TryParse(update.CallbackQuery.Data, out int tmp);
                context.State = new ChooseDateTimeState(tmp);
            }
        

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            var srvices = _servicesServices.GetAllServices();
            var c = new InlineKeyboardButton[srvices.Count];

            for (int i = 0; i < srvices.Count; i++)
            {
                    c[i] = new InlineKeyboardButton(srvices[i].Name) { CallbackData = srvices[i].Id.ToString() };
                   
            }

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(c);

            var sent = botClient.SendTextMessageAsync(context.ChatId, "Choose a response", replyMarkup: markup);

        }
    }
}
