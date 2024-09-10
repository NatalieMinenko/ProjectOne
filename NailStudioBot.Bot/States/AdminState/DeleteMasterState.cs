using NailStudioBot.BLL;
using NailStudioBot.Bot.Statettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailStudioBot.Bot.States.AdminState
{
    public class DeleteMasterState : AbstractState
    {
        private UserService _userService;
        public DeleteMasterState()
        {
            _userService = new UserService(); 
        }

        public override void HandleMessage(Context context, Update update)
        {
            if (int.TryParse(update.Message.Text, out int id))
            {
                if (_userService.UserExists(id))
                {
                    _userService.DeleteUser(id);
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
            botClient.SendTextMessageAsync(context.ChatId, "Введите ID пользователя, которого хотите удалить:");
        }
    }
}
