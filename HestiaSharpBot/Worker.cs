using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace HestiaSharpBot
{
    public class Worker : BackgroundService
    {
        private readonly TelegramBotClient _bot;
        private readonly List<long> _chatIds = [];
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _bot = new TelegramBotClient
                (Environment.GetEnvironmentVariable("TELEGRAM_TOKEN") ?? throw new InvalidOperationException());

            _bot.OnMessage += OnMessageReceived;

            var startCommand = new BotCommand("/start", "Get timed chats.");
            var stopCommand = new BotCommand("/stop", "Stop getting timed chats.");
            _bot.SetMyCommands([startCommand, stopCommand,]);
        }

        private async Task OnMessageReceived(Message message, UpdateType type)
        {
            if (message.Text == "/start")
            {
                if (!_chatIds.Contains(message.Chat.Id))
                {
                    _chatIds.Add(message.Chat.Id);
                }

                await _bot.SendMessage(message.Chat, "You wil now get updates.");
            }
            else if (message.Text == "/stop")
            {
                if (_chatIds.Contains(message.Chat.Id))
                {
                    _chatIds.Remove(message.Chat.Id);
                }

                await _bot.SendMessage(message.Chat, "You will no longer get updates.");
            }
            else
            {
                await _bot.SendMessage(message.Chat, "You can only send /start");
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Found {int} users", _chatIds.Count);

                    foreach (var chatId in _chatIds)
                    {
                        var chat = _bot.GetChat(chatId, stoppingToken);
                        await _bot.SendMessage(chatId, "Hello from automated tekst", cancellationToken: stoppingToken);
                    }
                }

                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            }
        }
    }
}