using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HestiaStore.DTO;

namespace HestiaStore.Entities
{
    [Table("agencies")]
    public class Agency : IAgency
    {
        private IEnumerable<IHome> _homes = new List<Home>();

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Name { get; set; }

        public IEnumerable<IHome> Homes
        {
            get => _homes;

            set => _homes = value;
        }
    }
}