using HestiaSharp.zig365;
using Newtonsoft.Json.Linq;
using IAgency = HestiaSharp.Interfaces.IAgency;

namespace HestiaSharp.FrieslandHuurt
{
    public class FrieslandHuurtScraper : Zig365Scraper
    {
        public FrieslandHuurtScraper(Frieslandhuurt frieslandhuurt, DateTime? lastScrape = null)
        {
            Agency = frieslandhuurt;
            LastScrape = lastScrape ?? DateTime.Today;
        }

        public override IAgency Agency { get; }

        public override Uri ApiUrl { get; } = new
            ("https://frieslandhuurt-aanbodapi.zig365.nl/api/v1/actueel-aanbod?locale=nl_NL&page=0&sort=+publicationDate");

        protected override string GetFilter()
        {
            var filter = File.ReadAllText("/app/FrieslandHuurt/Filter.json");
            var jsonFilter = JObject.Parse(filter);
            jsonFilter["filters"]!["$and"]![1]!["$or"]![0]!["publicationDate"]!["$gte"] = LastScrape.ToString
                ("yyyy-MM-ddTHH:00:00.000Z");

            return jsonFilter.ToString();
        }
    }
}