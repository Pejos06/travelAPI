using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using travelAPI.Entities;
using travelAPI.Modules.Monuments;

namespace travelAPI.Modules.Countries
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Capitol { get; set;}
        public string CountryDescription { get; set; }
        public string ContinentName { get; set; }
        public List<MonumentDTO> Monuments { get; set; }
    }
}