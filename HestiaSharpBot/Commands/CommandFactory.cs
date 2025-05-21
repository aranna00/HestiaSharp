namespace HestiaSharpBot.Commands
{
    public static class CommandFactory
    {
        public static ICommand? GetCommandForBot(string message, IMessageBot messageBot)
        {
            return message switch
            {
                "/start" => messageBot.Commands["start"],
                "/stop"  => messageBot.Commands["stop"],
                _        => null,
            };
        }
    }
}