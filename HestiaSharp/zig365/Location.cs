using HestiaStore.DTO;

namespace HestiaSharp.zig365
{
    public class Location(int id, string name) : ILocation
    {
        public int Id { get; set; }

        public string Name { get; set; } = name;
    }
}