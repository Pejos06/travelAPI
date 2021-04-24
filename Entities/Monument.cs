namespace travelAPI.Entities
{
    public class Monument
    {
        public int Id { get; set; }
        public string MonumentName { get; set; }
        public string MonumentDescription { get; set; }
        public string MonumentPhoto { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}