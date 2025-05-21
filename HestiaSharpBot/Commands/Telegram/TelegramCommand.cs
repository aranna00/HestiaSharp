using Telegram.Bot.Types;

namespace HestiaSharpBot.Commands.Telegram
{
    public abstract class TelegramCommand : BotCommand, ICommand
    {
        public abstract Task Respond(Chat chat);
    }
}