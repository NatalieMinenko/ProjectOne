using NailStudioBot.Bot;
using NailStudioBot.Bot.Statettes;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using NailStudioBot.Bot.States.AdminState;
using NailStudioBot.Bot.States.MasterStates.MasterServicesStates;
using NailStudioBot.BLL;
using NailStudioBot.Core.InputModels;

namespace NailStudioBot.Bot.States.MasterStates
{
    public class MasterIdState : AbstractState
    {
        private UserService _userService;

        public MasterIdState()
        {
            _userService = new UserService();
        }

        public override void HandleMessage(Context context, Update update)
        {

            if (int.TryParse(update.Message.Text, out int id))
            {
                if (_userService.UserExists(id))
                {
                    context.BotClient.SendTextMessageAsync(context.ChatId, $"Пользователь с ID {id} авторизован");

                    context.State = new MasterMenuState();
                }
                else
                {
                    context.BotClient.SendTextMessageAsync(context.ChatId, $"Пользователь с ID {id} не найден");

                    context.State = new LoginMasterState();
                }
            }
            else
            {
                context.BotClient.SendTextMessageAsync(context.ChatId, "Пожалуйста, введите корректный ID пользователя");

                context.State = new LoginMasterState();
            }

        }

        public override void ReactInBot(Context context, ITelegramBotClient botClient)
        {
            botClient.SendTextMessageAsync(new ChatId(context.ChatId), "Введите свой ID");
        }

    }
}
