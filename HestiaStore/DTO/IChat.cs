namespace HestiaStore.DTO
{
    public interface IChat
    {
        string Id { get; set; }

        string Type { get; set; }

        bool Active { get; set; }

        string? Filter { get; set; }
    }
}