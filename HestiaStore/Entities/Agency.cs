namespace HestiaStore.Entities
{
    public class Agency
    {
        private List<Home> _homes = [];

        public int Id { get; set; }

        public required string Name { get; set; }

        public List<Home> Homes
        {
            get => _homes;

            set => _homes = value;
        }
    }
}