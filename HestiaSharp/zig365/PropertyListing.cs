namespace HestiaSharp.zig365
{
    public class PropertyListing
    {
        public int ID { get; set; }

        public string? PostalCode { get; set; }

        public string? Street { get; set; }

        public string? HouseNumber { get; set; }

        public string? HouseNumberAddition { get; set; }

        public string? GemeenteGeoLocatieNaam { get; set; }

        public string? RentBuy { get; set; }

        public string? VHE { get; set; }

        public bool Zonnepanelen { get; set; }

        public bool GaslozeWoning { get; set; }

        public bool NulOpDeMeterWoning { get; set; }

        public DateTime? AvailableFromDate { get; set; }

        public decimal TotalRent { get; set; }

        public decimal NetRent { get; set; }

        public decimal CalculationRent { get; set; }

        public decimal? ServiceCosts { get; set; }

        public decimal? HeatingCosts { get; set; }

        public decimal? AdditionalCosts { get; set; }

        public decimal EenmaligeKosten { get; set; }

        public bool FlexibelHurenActief { get; set; }

        public decimal? SellingPrice { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string? ReactieUrl { get; set; }

        public bool NewlyBuild { get; set; }

        public int AreaDwelling { get; set; }

        public int? VolumeDwelling { get; set; }

        public int? AreaPerceel { get; set; }

        public int AreaLivingRoom { get; set; }

        public string? AreaSleepingRoom { get; set; }

        public bool HasTuin { get; set; }

        public bool HasStorageRoom { get; set; }

        public bool HasBalcony { get; set; }

        public string? ConstructionYear { get; set; }

        public Location? Land { get; set; }

        public Location? Municipality { get; set; }

        public City? City { get; set; }

        public Quarter? Quarter { get; set; }

        public Corporation? Corporation { get; set; }

        public DwellingType? DwellingType { get; set; }

        public EnergyLabel? EnergyLabel { get; set; }

        public NamedEntity? Heating { get; set; }

        public Room? SleepingRoom { get; set; }

        public NamedEntity? Kitchen { get; set; }

        public NamedEntity? Attic { get; set; }

        public List<SpecialFeature> SpecifiekeVoorzieningen { get; set; } = new();

        public List<TargetGroup> Doelgroepen { get; set; } = new();

        public List<string> Floorplans { get; set; } = new();

        public List<Picture> Pictures { get; set; } = new();

        public string? UrlKey { get; set; }

        public bool InschrijvingVereistVoorReageren { get; set; }

        public string? Infoveld { get; set; }

        public string? InfoveldKort { get; set; }

        public bool IsGepubliceerd { get; set; }
    }
}