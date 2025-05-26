using HestiaSharp.Interfaces;

namespace HestiaSharp
{
    internal class Program
    {
        private static readonly List<IAgency> _agencies = [];

        private static async Task Main(string[] args)
        {
            foreach (var agency in _agencies)
            {
                await agency.Scraper.Scrape();
            }
        }
    }
}