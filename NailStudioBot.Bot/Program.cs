using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Polling;
using NailStudioBot.Core.InputModels;

namespace NailStudioBot.Bot
{
    public class Program
    {
        public static Dictionary<long, string> States { get; set; }

        //private static UserService _userService;

        public static void Main(string[] args)
        {
            States = new Dictionary<long, string>();

            //_userService = new UserService();

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

                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Ну я заработал, короч");
                    await botClient.SendTextMessageAsync(message.Chat, $"Тебя зовут {message.Chat.FirstName}");

                    if (!States.ContainsKey(message.Chat.Id))
                    {
                        States.Add(message.Chat.Id, "start");
                    }

                }
                else if (message.Text == "1" && States[id] == "start")
                {
                    States[id] = "add";
                    await botClient.SendTextMessageAsync(message.Chat, "Введите имя!");
                }
                else if (States[id] == "add")
                {
                    //тут будем добавлять юзера
                    var user = new UsersInputModel()
                    {
                        Name = message.Text,
                    };

                    //_userService.AddUser(user);

                    States[id] = "start";
                }
                else if (message.Text == "2" && States[id] == "start")
                {
                    //var users = _userService.GetAllUsers();

                    //string res = "";

                    //foreach (var user in users)
                    //{
                    //    res += $"{user.Id}-{user.Name}\n";
                    //}

                    await botClient.SendTextMessageAsync(message.Chat, "kk");
                }
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(exception.ToString());
        }

    }
}
