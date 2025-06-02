namespace HestiaSharp.Interfaces
{
    public interface IScraper
    {
        IAgency Agency { get; }

        Uri ApiUrl { get; }

        Task Scrape();
    }
}