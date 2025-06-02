using HestiaSharp.FrieslandHuurt;
using HestiaSharp.Interfaces;

namespace HestiaSharp
{
    internal class Program
    {
        private static readonly List<IAgency> _agencies =
        [
            new Frieslandhuurt(),
        ];

        private static async Task Main(string[] args)
        {
            foreach (var agency in _agencies)
            {
                await agency.Scraper.Scrape();
            }
        }
    }
}