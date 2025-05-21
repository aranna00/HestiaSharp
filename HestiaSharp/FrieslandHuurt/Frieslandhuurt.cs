namespace HestiaSharp.FrieslandHuurt
{
    public class Frieslandhuurt : IAgency
    {
        public IScraper Scraper { get; set; }

        public string Name { get; set; } = "Frieslandhuurt";

        public string BaseUrl { get; set; }
    }
}