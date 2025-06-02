namespace HestiaStore.DTO
{
    public interface IAgency
    {
        int Id { get; set; }

        string Name { get; set; }

        IEnumerable<IHome> Homes { get; set; }
    }
}