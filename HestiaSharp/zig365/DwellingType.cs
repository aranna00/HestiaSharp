using HestiaStore.DTO;

namespace HestiaSharp.zig365
{
    public class DwellingType : IDwellingType
    {
        public bool HuurprijsDuurActief { get; set; }

        public string? Categorie { get; set; }

        public string? Code { get; set; }

        public string? LocalizedName { get; set; }

        public int Id { get; set; }

        public string? Name { get; set; }
    }
}