using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HestiaStore.Entities
{
    [Table("homes")]
    public class Home
    {
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
        public required City City { get; set; }

        [Required]
        public required Agency Agency { get; set; }

        public bool? SolarPanels { get; set; }

        public bool? GasLess { get; set; }

        public bool? ZeroOnTheMeter { get; set; }

        public DateTime AvailableFrom { get; set; }

        public int TotalPrice { get; set; }

        public bool NewlyBuild { get; set; }

        public int? LivinArea { get; set; }

        public bool HasGarden { get; set; }

        public bool HasBalcony { get; set; }

        public bool HasStorageRoom { get; set; }

        public Location? Municipality { get; set; }

        public DwellingType? DwellingType { get; set; }

        public EnergyLabel? EnergyLabel { get; set; }

        public List<TargetGroup>? TargetGroups { get; set; }

        public int? Rooms { get; set; }
    }
}