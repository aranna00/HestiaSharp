using HestiaStore.DTO;
using Newtonsoft.Json;

namespace HestiaSharp.zig365
{
    public class PropertyListing : IHome
    {
        private IAgency _agency;
        private DateTime _availableFrom;
        private bool? _gasLess;
        private bool _hasGarden;
        private int? _livingArea;
        private bool? _solarPanels;
        private IEnumerable<ITargetGroup>? _targetGroups;
        private int _totalPrice;
        private bool? _zeroOnTheMeter;

        public string? RentBuy { get; set; }

        public string? VHE { get; set; }

        public decimal NetRent { get; set; }

        public decimal CalculationRent { get; set; }

        public decimal? ServiceCosts { get; set; }

        public decimal? HeatingCosts { get; set; }

        public decimal? AdditionalCosts { get; set; }

        public decimal EenmaligeKosten { get; set; }

        public bool FlexibelHurenActief { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string? ReactieUrl { get; set; }

        public int? VolumeDwelling { get; set; }

        public int? AreaPerceel { get; set; }

        public int AreaLivingRoom { get; set; }

        public string? AreaSleepingRoom { get; set; }

        public string? ConstructionYear { get; set; }

        public Location? Land { get; set; }

        public District? Quarter { get; set; }

        public Corporation? Corporation { get; set; }

        public NamedEntity? Heating { get; set; }

        public Room? SleepingRoom { get; set; }

        public NamedEntity? Kitchen { get; set; }

        public NamedEntity? Attic { get; set; }

        public List<SpecialFeature> SpecifiekeVoorzieningen { get; set; } = new();

        public List<string> Floorplans { get; set; } = new();

        public List<Picture> Pictures { get; set; } = new();

        public string? UrlKey { get; set; }

        public bool InschrijvingVereistVoorReageren { get; set; }

        public string? Infoveld { get; set; }

        public string? InfoveldKort { get; set; }

        public bool IsGepubliceerd { get; set; }

        public int Id { get; set; }

        public string PostalCode { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string? HouseNumberAddition { get; set; }

        public bool HasStorageRoom { get; set; }

        public bool HasBalcony { get; set; }

        public ILocation? Municipality { get; set; }

        public ICity? City { get; set; }

        public IDwellingType? DwellingType { get; set; }

        public IEnergyLabel? EnergyLabel { get; set; }

        public bool NewlyBuild { get; set; }

        [JsonProperty(PropertyName = "TotalRent")]
        public int TotalPrice
        {
            get => _totalPrice;

            set => _totalPrice = value;
        }

        [JsonProperty(PropertyName = "AreaDwelling")]
        public int? LivingArea
        {
            get => _livingArea;

            set => _livingArea = value;
        }

        [JsonProperty(PropertyName = "tuin")]
        public bool HasGarden
        {
            get => _hasGarden;

            set => _hasGarden = value;
        }

        [JsonIgnore]
        public IAgency Agency
        {
            get => _agency;

            set => _agency = value;
        }

        [JsonProperty(PropertyName = "Zonnepanelen")]
        public bool? SolarPanels
        {
            get => _solarPanels;

            set => _solarPanels = value;
        }

        [JsonProperty(PropertyName = "GaslozeWoning")]
        public bool? GasLess
        {
            get => _gasLess;

            set => _gasLess = value;
        }

        [JsonProperty(PropertyName = "NulOpDeMeterWoning")]
        public bool? ZeroOnTheMeter
        {
            get => _zeroOnTheMeter;

            set => _zeroOnTheMeter = value;
        }

        [JsonProperty(PropertyName = "AvailableFromDate")]
        public DateTime AvailableFrom
        {
            get => _availableFrom;

            set => _availableFrom = value;
        }

        [JsonProperty(PropertyName = "Doelgroepen")]
        public IEnumerable<ITargetGroup>? TargetGroups
        {
            get => _targetGroups;

            set => _targetGroups = value;
        }

        public int? Rooms
        {
            get => SleepingRoom?.AmountOfRooms;

            set
            {
                if (SleepingRoom != null)
                {
                    SleepingRoom.AmountOfRooms = value ?? 0;
                }
            }
        }
    }
}