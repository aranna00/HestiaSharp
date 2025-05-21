namespace HestiaSharpBot.Commands
{
    public interface ICommand
    {
        string Command { get; }

        string Description { get; }
    }
}