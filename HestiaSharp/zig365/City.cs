using HestiaStore.DTO;

namespace HestiaSharp.zig365
{
    public class City(int id, string name, ILocation? gemeente) : Location(id, name), ICity
    {
        public ILocation? Gemeente { get; set; } = gemeente;
    }
}