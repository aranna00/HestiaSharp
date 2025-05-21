namespace HestiaSharp
{
    public interface IAgency
    {
        IScraper Scraper { get; set; }

        string Name { get; set; }

        string BaseUrl { get; set; }
    }
}