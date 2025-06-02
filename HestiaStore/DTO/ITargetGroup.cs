namespace HestiaStore.DTO
{
    public interface ITargetGroup
    {
        int Id { get; set; }

        string Name { get; set; }

        int? MinAge { get; set; }

        int? MaxAge { get; set; }

        bool? AidHome { get; set; }

        int? MinimumOccupants { get; set; }

        int? MaximumOccupants { get; set; }
    }
}