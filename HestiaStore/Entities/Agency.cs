using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HestiaStore.Entities
{
    [Table("agencies")]
    public class Agency
    {
        private List<Home> _homes = [];

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Name { get; set; }

        public List<Home> Homes
        {
            get => _homes;

            set => _homes = value;
        }
    }
}