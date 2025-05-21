namespace HestiaSharp.FrieslandHuurt
{
    public class FrieslandHuurtScraper(DateTime lastScrape) : IScraper
    {
        private string _apiUrl
            = "https://frieslandhuurt-aanbodapi.zig365.nl/api/v1/actueel-aanbod?locale=nl_NL&sort=+availableFromDate";

        private DateTime _lastScrape = lastScrape;
        private string filterSinceLastScrape = "";

        public void SetBaseFilter() { }
    }
}