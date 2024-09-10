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
    public class AddMasterPhone : AbstractState
    {
        private UserService _userService;

        private UsersInputModel _userModel;
        public AddMasterPhone(UsersInputModel usersInputModel)
        {
            _userModel = usersInputModel;
            _userService = new UserService();
        }
        public override void HandleMessage(Context context, Update update)
        {

            _userModel.Phone = update.Message.Text;
            _userService.AddUser(_userModel);
            context.State = new AdminMenuState();

        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            var sent = botClient.SendTextMessageAsync(context.ChatId, "Введите телефон");
        }
    }
}
