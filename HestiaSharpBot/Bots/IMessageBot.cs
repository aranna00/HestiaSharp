using HestiaSharpBot.Commands;

namespace HestiaSharpBot
{
    public interface IMessageBot
    {
        Dictionary<string, ICommand> Commands { get; set; }

        Task SendBroadCast(string message, CancellationToken stoppingToken);
    }
}