using ICity = HestiaStore.DTO.ICity;

namespace HestiaSharp.zig365
{
    public class District(int id, string name, ICity city) : Location(id, name)
    {
        public ICity City { get; set; }
    }
}