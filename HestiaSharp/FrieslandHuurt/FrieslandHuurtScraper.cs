using HestiaSharp.Interfaces;
using Newtonsoft.Json.Linq;

namespace HestiaSharp.FrieslandHuurt
{
    public class FrieslandHuurtScraper : IScraper
    {
        private static readonly Uri _apiUrl = new
            ("https://frieslandhuurt-aanbodapi.zig365.nl/api/v1/actueel-aanbod?locale=nl_NL&sort=+availableFromDate");

        private DateTime _lastScrape;
        private string filterSinceLastScrape = "";

        public FrieslandHuurtScraper(DateTime lastScrape)
        {
            _lastScrape = lastScrape;
        }

        public async Task Scrape()
        {
            await Task.Delay(1000);

            throw new NotImplementedException();
        }

        public string GetFilter()
        {
            var filter = File.ReadAllText("D:\\Development\\HestiaSharp\\HestiaSharp\\zig365\\Filter.json");
            var jsonFilter = JObject.Parse(filter);
            jsonFilter["filters"]!["$and"]![1]!["$or"]![0]!["publicationDate"]!["$gte"]
                = DateTime.Now.AddHours(-1).ToString("yyyy-MM-ddTHH:00:00.000Z");

            return jsonFilter.ToString();
        }
    }
}