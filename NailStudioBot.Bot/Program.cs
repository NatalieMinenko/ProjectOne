using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Polling;
using NailStudioBot.BLL;
using NailStudio.DAL;
using System.Xml.Linq;
using NailStudioBot.Bot.States.ClientStates;
using NailStudioBot.Bot.Statettes.AdmonState;
using NailStudioBot.Bot.States.MasterStates;
using NailStudioBot.Bot.States;
using NailStudioBot.Bot.States.AdminState;
using System.Runtime.InteropServices;


namespace NailStudioBot.Bot

{
    public class Program
    {
        public static Dictionary<long, Context> Clients { get; set; }

        public static void Main(string[] args)
        {
            Clients = new Dictionary<long, Context>();

            ITelegramBotClient BotClient = new TelegramBotClient(Environment.GetEnvironmentVariable("TGtokenNogotochki"));

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }
            };

            BotClient.StartReceiving(
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

                Context crntClient;

                if (Clients.ContainsKey(message.Chat.Id))
                {
                    crntClient = Clients.First(x => x.Key == message.Chat.Id).Value;
                    crntClient.HandleMessage(update);
                }
                else
                {
                    //Сохраняем его в базку или загружаем
                    crntClient = new Context();
                    crntClient.ChatId = message.Chat.Id;
                            crntClient.State = new StartState();
                    Clients.Add(message.Chat.Id, crntClient);   
                }


                crntClient.ReactInBot(botClient);
            }
            else if (update.Type == UpdateType.CallbackQuery)
            {
                var message = update.CallbackQuery.Message;


                Context crntClient;

                if (Clients.ContainsKey(message.Chat.Id))
                {
                    crntClient = Clients.First(x => x.Key == message.Chat.Id).Value;
                    crntClient.HandleMessage(update);
                }
                else
                {
                    //Сохраняем его в базку или загружаем
                    crntClient = new Context();
                    crntClient.ChatId = message.Chat.Id;
                    crntClient.State = new AdminMenuState();
                    Clients.Add(message.Chat.Id, crntClient);
                }

                crntClient.ReactInBot(botClient);
            }

        }
        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(exception.ToString());
        }
    }
}
