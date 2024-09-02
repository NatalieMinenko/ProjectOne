using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Polling;
using NailStudioBot.Core.InputModels;
using NailStudioBot.BLL;
using NailStudio.DAL;
using System.Xml.Linq;


namespace NailStudioBot.Bot

        

{
    public class Program
    {
        

        public static Dictionary<long, string> States { get; set; }

        private static UserService _userService;

        public static void Main(string[] args)
        {
            States = new Dictionary<long, string>();

            _userService = new UserService();

            ITelegramBotClient bot = new TelegramBotClient("6997618609:AAEIBEGrUEXn7LXUK5y33vjjPmaMsGfs6SQ");

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = {}
            };

            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

            Console.WriteLine("ЗАРАБОТАЛО!!!");

            Console.ReadLine();
        }

   

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message)
            {
                var message = update.Message;
                var id = message.Chat.Id;
                if (!States.ContainsKey(id))
                {
                    States[id] = "start";
                }

                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Ну я заработал, короч");
                    await botClient.SendTextMessageAsync(message.Chat, $"Тебя зовут {message.Chat.FirstName}");

                    if (!States.ContainsKey(message.Chat.Id))
                    {
                        States.Add(message.Chat.Id, "start");
                    }

                }
                else if (message.Text == "1")
                {
                    States[id] = "add";
                    await botClient.SendTextMessageAsync(message.Chat, "Введите имя!");
                }
                else if (message.Text == "add")
                {
                    //тут будем добавлять юзера
                    var user = new UsersInputModel()
                    {
                        Name = message.Text,
                        
                    };

                    _userService.AddUser(user);

                    States[id] = "start";
                }
                else if (message.Text == "2")
                {
                    var users = _userService.GetAllUsers();
                    string res = "";

                    foreach (var user in users)
                    {
                        res += $@"{user.Id} - {user.Name}
";
                    }

                    await botClient.SendTextMessageAsync(message.Chat, res);
                }
                //else if (message.Text == "3")
                //{
                //    States[id] = "update";
                //    await botClient.SendTextMessageAsync(message.Chat, "Введите ID пользователя, которого хотите обновить:");
                //}
                //else if (States[id] == "update")
                //{
                //    if (int.TryParse(message.Text, out int userId))
                //    {
                //        var user = _userService.GetUsersById(userId);
                //        if (user != null)
                //        {
                //            States[id] = "update_name";
                //            await botClient.SendTextMessageAsync(message.Chat, "Введите новое имя:");
                //        }
                //        else
                //        {
                //            await botClient.SendTextMessageAsync(message.Chat, "Пользователь с таким ID не найден.");
                //            States[id] = "start";
                //        }
                //    }
                //    else
                //    {
                //        await botClient.SendTextMessageAsync(message.Chat, "Неверный формат ID.");
                //        States[id] = "start";
                //    }
                //}
                //else if (States[id] == "update_name")
                //{
                //    var user = new UsersInputModel()
                //    {
                //        //Id = userId,
                //        Name = message.Text,
                //    };

                //    _userService.UpdateUser(user);
                //    await botClient.SendTextMessageAsync(message.Chat, "Пользователь обновлен!");
                //    States[id] = "start";
                //}



            }
        }


        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(exception.ToString());
        }

    }
}
