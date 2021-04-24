using System.Collections.Generic;

namespace travelAPI.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Capitol { get; set;}
        public int Population { get; set; }
        public int Area { get; set; }
        public string CountryDescription { get; set; }
        public string CountryFlag { get; set; }
        public int ContinentId { get; set; }
        public virtual Continent Continent { get; set; }
        public virtual List<Monument> Monuments { get; set; }
    }
}

