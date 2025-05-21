using HestiaSharpBot.Bots.Telegram;
using Telegram.Bot.Types;

namespace HestiaSharpBot.Commands.Telegram
{
    public class StopCommand : TelegramCommand
    {
        private readonly TelegramBot _bot;

        public StopCommand(TelegramBot bot)
        {
            _bot = bot;
            Command = "/stop";
            Description = "Stop receiving timed chats.";
        }

        public override async Task Respond(Chat chat)
        {
            if (_bot.ChatIds.Contains(chat.Id))
            {
                _bot.ChatIds.Remove(chat.Id);
            }

            await _bot.SendMessage(chat, "You will no longer get updates.");
        }
    }
}