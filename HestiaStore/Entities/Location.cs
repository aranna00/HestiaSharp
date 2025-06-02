using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HestiaStore.Entities
{
    [Table("locations")]
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }
    }
}