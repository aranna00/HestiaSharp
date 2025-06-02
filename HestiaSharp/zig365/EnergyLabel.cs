using HestiaStore.DTO;
using Newtonsoft.Json;

namespace HestiaSharp.zig365
{
    public class EnergyLabel : IEnergyLabel
    {
        public string? Icon { get; set; }

        public int Id { get; set; }

        [JsonProperty(PropertyName = "LocalizedNaam")]
        public string Name { get; set; }
    }
}