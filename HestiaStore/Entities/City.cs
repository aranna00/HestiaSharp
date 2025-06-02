using System.ComponentModel.DataAnnotations.Schema;
using HestiaStore.DTO;

namespace HestiaStore.Entities
{
    [Table("cities")]
    public class City : Location, ICity
    {
        public ILocation? Gemeente { get; set; }
    }
}