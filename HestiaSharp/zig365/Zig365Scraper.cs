using System.Text;
using HestiaSharp.Interfaces;
using Newtonsoft.Json.Linq;

namespace HestiaSharp.zig365
{
    public abstract class Zig365Scraper : IScraper
    {
        private DateTime _lastScrape;

        protected DateTime LastScrape
        {
            get => _lastScrape;
            set => _lastScrape = value;
        }

        public abstract IAgency Agency { get; }

        public abstract Uri ApiUrl { get; }

        public async Task Scrape()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = ApiUrl;
            var filter = GetFilter();
            var response = await httpClient.PostAsync("", new StringContent(filter, Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var jsonData = JObject.Parse(content);

                foreach (var homeData in jsonData["data"]!)
                {
                    var listing = new PropertyListing();
                    listing.Id = homeData["id"]!.Value<int>();
                    listing.Agency = Agency;
                    listing.PostalCode = homeData["postalcode"]!.Value<string>()!;
                    listing.Street = homeData["street"]!.Value<string>()!;
                    listing.HouseNumber = homeData["houseNumber"]!.Value<string>()!;
                    listing.HouseNumberAddition = homeData["houseNumberAddition"]!.Value<string>();
                    listing.SolarPanels = homeData["zonnepanelen"]!.Value<bool>();
                    listing.GasLess = homeData["gaslozeWoning"]!.Value<bool>();
                    listing.ZeroOnTheMeter = homeData["nulOpDeMeterWoning"]!.Value<bool>();
                    listing.AvailableFrom = homeData["availableFromDate"]!.Value<DateTime>();
                    listing.TotalPrice = (int)double.Round(homeData["totalRent"]!.Value<double>(), 0);
                    listing.NewlyBuild = homeData["newlyBuild"]!.Value<bool>();
                    listing.LivingArea = homeData["areaDwelling"]!.Value<int>();
                    listing.AreaSleepingRoom = homeData["areaSleepingRoom"]!.Value<string>();
                    listing.HasGarden = homeData["tuin"]!.Value<bool>();
                    listing.HasStorageRoom = homeData["storageRoom"]!.Value<bool>();
                    listing.HasBalcony = homeData["balcony"]!.Value<bool>();
                    listing.ConstructionYear = homeData["constructionYear"]!.Value<string>();
                    var municipalityData = homeData["municipality"]!;
                    listing.Municipality = new Location
                        (municipalityData["id"]!.Value<int>(), municipalityData["name"]!.Value<string>()!);

                    var cityData = homeData["city"]!;
                    listing.City = new City
                        (cityData["id"]!.Value<int>(), cityData["name"]!.Value<string>()!, listing.Municipality);

                    var districtData = homeData["quarter"]!;
                    listing.Quarter = new District
                        (districtData["id"]!.Value<int>(), districtData["name"]!.Value<string>()!, listing.City);

                    var corporationData = homeData["corporation"]!;
                    listing.Corporation = new Corporation
                    {
                        Id = corporationData["id"]!.Value<int>(),
                        Code = corporationData["id"]!.Value<string>()!,
                        Name = corporationData["localizedName"]!.Value<string>()!,
                        Logo = corporationData["logo"]!.Value<string>()!,
                        HuurtoeslagTonen = corporationData["huurtoeslagTonen"]!.Value<bool>(),
                    };

                    var dwellingTypeData = homeData["dwellingType"]!;
                    listing.DwellingType = new DwellingType
                    {
                        Id = dwellingTypeData["id"]!.Value<int>(),
                        HuurprijsDuurActief = dwellingTypeData["huurprijsDuurActief"]!.Value<bool>(),
                        Categorie = dwellingTypeData["categorie"]!.Value<string>(),
                        Code = dwellingTypeData["code"]!.Value<string>(),
                        Name = dwellingTypeData["name"]!.Value<string>(),
                        LocalizedName = dwellingTypeData["localizedName"]!.Value<string>(),
                    };
                }
            }

            LastScrape = DateTime.Now;
        }

        protected abstract string GetFilter();
    }
}