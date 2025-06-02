namespace HestiaSharp.Interfaces
{
    public interface IAgency : HestiaStore.DTO.IAgency
    {
        string Name { get; set; }

        string BaseUrl { get; set; }

        IScraper Scraper { get; set; }
    }
}