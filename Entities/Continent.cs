using System.Collections.Generic;

namespace travelAPI.Entities
{
    public class Continent
    {
        public int Id { get; set; }
        public string ContinentName { get; set; }
        public string ContinentDescription { get; set; }
        public string ContinentPhoto { get; set; }

        public virtual List<Country> Countries { get; set; }
    }
}