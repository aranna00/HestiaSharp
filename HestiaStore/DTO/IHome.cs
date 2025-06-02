namespace HestiaStore.DTO
{
    public interface IHome
    {
        int Id { get; set; }

        string PostalCode { get; set; }

        string Street { get; set; }

        string HouseNumber { get; set; }

        string? HouseNumberAddition { get; set; }

        ICity City { get; set; }

        IAgency Agency { get; set; }

        bool? SolarPanels { get; set; }

        bool? GasLess { get; set; }

        bool? ZeroOnTheMeter { get; set; }

        DateTime AvailableFrom { get; set; }

        int TotalPrice { get; set; }

        bool NewlyBuild { get; set; }

        int? LivingArea { get; set; }

        bool HasGarden { get; set; }

        bool HasBalcony { get; set; }

        bool HasStorageRoom { get; set; }

        ILocation? Municipality { get; set; }

        IDwellingType? DwellingType { get; set; }

        IEnergyLabel? EnergyLabel { get; set; }

        IEnumerable<ITargetGroup>? TargetGroups { get; set; }

        int? Rooms { get; set; }
    }
}