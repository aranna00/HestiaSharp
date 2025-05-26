using HestiaSharp.Interfaces;

namespace HestiaSharp
{
    public class Home
    {
        public IAgency Agency { get; set; }

        public string Url { get; set; }

        public ICity City { get; set; }

        public int Price { get; set; }

        public DateTime DateAdded { get; set; }

        public int RoomCount { get; set; }

        public string HoueseType { get; set; }

        public string HouseTarget { get; set; }
    }
}