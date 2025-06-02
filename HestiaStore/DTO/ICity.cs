namespace HestiaStore.DTO
{
    public interface ICity : ILocation
    {
        ILocation? Gemeente { get; set; }
    }
}