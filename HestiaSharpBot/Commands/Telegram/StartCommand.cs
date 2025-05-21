using HestiaSharpBot.Bots.Telegram;
using Telegram.Bot.Types;

namespace HestiaSharpBot.Commands.Telegram
{
    public class StartCommand : TelegramCommand
    {
        private readonly TelegramBot _bot;

        public StartCommand(TelegramBot bot)
        {
            _bot = bot;
            Command = "/start";
            Description = "Get timed chats.";
        }

        public override async Task Respond(Chat chat)
        {
            if (!_bot.ChatIds.Contains(chat.Id))
            {
                _bot.ChatIds.Add(chat.Id);
            }

            await _bot.SendMessage(chat, "You wil now get updates.");
        }
    }
}