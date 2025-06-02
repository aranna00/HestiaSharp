using HestiaSharp.Interfaces;
using HestiaStore.DTO;
using IAgency = HestiaSharp.Interfaces.IAgency;

namespace HestiaSharp.FrieslandHuurt
{
    public class Frieslandhuurt : IAgency
    {
        public Frieslandhuurt()
        {
            Scraper = new FrieslandHuurtScraper(this, DateTime.Today);
        }

        public IScraper Scraper { get; set; }

        public int Id { get; set; }

        public string Name { get; set; } = "Frieslandhuurt";

        public IEnumerable<IHome> Homes { get; set; }

        public string BaseUrl { get; set; }
    }
}