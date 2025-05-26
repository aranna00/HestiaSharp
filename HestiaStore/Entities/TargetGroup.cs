namespace HestiaSharp.zig365
{
    public class TargetGroup
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int? MinAge { get; set; }

        public int? MaxAge { get; set; }

        public bool? AidHome { get; set; }

        public int? MinimumOccupants { get; set; }

        public int? MaximumOccupants { get; set; }
    }
}