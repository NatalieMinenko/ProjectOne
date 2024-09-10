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

namespace NailStudioBot.Bot.States.AdminState.MasterOperationStates
{
    public class AddMasterNameState : AbstractState
    {

        public override void HandleMessage(Context context, Update update)
        {
            var user = new UsersInputModel();
            user.Name = update.Message.Text;
            context.State = new AddMasterPhone(user);

        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            var sent = botClient.SendTextMessageAsync(context.ChatId, "Введите Имя");
        }
    }
}
