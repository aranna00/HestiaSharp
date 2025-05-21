using HestiaSharpBot.Bots.Telegram;
using Telegram.Bot;

namespace HestiaSharpBot.Bots
{
    public static class MessageBotFactory
    {
        private static readonly List<IMessageBot> Bots = [];

        public static void RegisterBots()
        {
            var telegramBotToken = Environment.GetEnvironmentVariable("TELEGRAM_TOKEN");

            if (telegramBotToken != null)
            {
                Bots.Add(new TelegramBot(new TelegramBotClient(telegramBotToken)));
            }
        }

        public static async Task BroadCastMessage(string message, CancellationToken stoppingToken)
        {
            foreach (var bot in Bots)
            {
                await bot.SendBroadCast(message, stoppingToken);
            }
        }
    }
}