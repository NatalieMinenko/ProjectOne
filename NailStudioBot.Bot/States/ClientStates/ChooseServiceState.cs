using NailStudio.DAL.Querys;
using NailStudioBot.BLL;
using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailStudioBot.Bot.States.ClientStates
{
    public class ChooseServiceState : AbstractState
    {
        public override void HandleMessage(Context context, Update update)
        {
            
        }

        public override async void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            var users = new ServicesServices().GetAllServices();

            string res = "";

            foreach (var user in users)
            {
                res += $"{user.Id}-{user.Name}\n";
            }

            await botClient.SendTextMessageAsync(new ChatId(context.ChatId), res);

            context.State = new ClientStartState();
        }
    }
}
