using HestiaSharpBot.Commands;
using HestiaSharpBot.Commands.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace HestiaSharpBot.Bots.Telegram
{
    public class TelegramBot : IMessageBot
    {
        private readonly TelegramBotClient _bot;
        private readonly List<long> _chatIds = [];
        private Dictionary<string, ICommand> _commands = new();

        public TelegramBot(TelegramBotClient bot)
        {
            _bot = bot;
            _bot.OnMessage += OnMessageReceived;

            CreateCommands();
            var registerCommandsTask = async () =>
            {
                await _bot.SetMyCommands(Commands.Select(x => (BotCommand)x.Value).ToList());
            };

            registerCommandsTask.Invoke();
        }

        public List<long> ChatIds
        {
            get => _chatIds;
        }

        public Dictionary<string, ICommand> Commands
        {
            get => _commands;

            set => _commands = value;
        }

        public async Task SendBroadCast(string message, CancellationToken stoppingToken)
        {
            foreach (var chatId in ChatIds)
            {
                await _bot.SendMessage(chatId, "Hello from automated tekst", cancellationToken: stoppingToken);
            }
        }

        private async Task OnMessageReceived(Message message, UpdateType type)
        {
            var command = CommandFactory.GetCommandForBot(message.Text!, this);

            if (command is not TelegramCommand telegramCommand)
            {
                await _bot.SendMessage(message.Chat, "Unknown command.");

                return;
            }

            await telegramCommand.Respond(message.Chat);
        }

        private void CreateCommands()
        {
            Commands.Add("start", new StartCommand(this));
            Commands.Add("stop", new StopCommand(this));
        }

        public async Task SendMessage(Chat chat, string message)
        {
            await _bot.SendMessage(chat, message);
        }
    }
}