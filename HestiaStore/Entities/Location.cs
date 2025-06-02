using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HestiaStore.DTO;

namespace HestiaStore.Entities
{
    [Table("locations")]
    public class Location : ILocation
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}