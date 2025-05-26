using HestiaSharp.zig365;

namespace HestiaStore.Entities
{
    public class City : Location
    {
        public Location? Gemeente { get; set; }
    }
}