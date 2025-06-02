using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HestiaStore.DTO;

namespace HestiaStore.Entities
{
    [Table("homes")]
    public class Home : IHome
    {
        [ForeignKey(nameof(Agency))]
        public int AgencyId { get; set; }

        public int Id { get; set; }

        [Required]
        [MaxLength(8)]
        public required string PostalCode { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Street { get; set; }

        [Required]
        [MaxLength(255)]
        public required string HouseNumber { get; set; }

        [MaxLength(5)]
        public string? HouseNumberAddition { get; set; }

        [Required]
        public required ICity City { get; set; }

        [Required]
        public required IAgency Agency { get; set; }

        public bool? SolarPanels { get; set; }

        public bool? GasLess { get; set; }

        public bool? ZeroOnTheMeter { get; set; }

        public DateTime AvailableFrom { get; set; }

        public int TotalPrice { get; set; }

        public bool NewlyBuild { get; set; }

        public int? LivingArea { get; set; }

        public bool HasGarden { get; set; }

        public bool HasBalcony { get; set; }

        public bool HasStorageRoom { get; set; }

        public ILocation? Municipality { get; set; }

        public IDwellingType? DwellingType { get; set; }

        public IEnergyLabel? EnergyLabel { get; set; }

        public IEnumerable<ITargetGroup>? TargetGroups { get; set; }

        public int? Rooms { get; set; }
    }
}