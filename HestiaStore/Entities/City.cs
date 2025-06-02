using System.ComponentModel.DataAnnotations.Schema;

namespace HestiaStore.Entities
{
    [Table("cities")]
    public class City : Location
    {
        public Location? Gemeente { get; set; }
    }
}