namespace HestiaSharp.Interfaces
{
    public interface IAgency
    {
        string Name { get; set; }

        string BaseUrl { get; set; }

        IScraper Scraper { get; set; }
    }
}