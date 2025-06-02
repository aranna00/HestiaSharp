using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HestiaStore.Entities
{
    [Table("target_groups")]
    public class TargetGroup
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Name { get; set; }

        public int? MinAge { get; set; }

        public int? MaxAge { get; set; }

        public bool? AidHome { get; set; }

        public int? MinimumOccupants { get; set; }

        public int? MaximumOccupants { get; set; }
    }
}