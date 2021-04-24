using AutoMapper;
using travelAPI.Entities;
using travelAPI.Modules.Monuments;

namespace travelAPI.Modules.Countries
{
    public class CountryMappingProfile: Profile
    {
        public CountryMappingProfile()
        {
            CreateMap<Country, CountryDTO>()
                .ForMember(m => m.ContinentName, c => c.MapFrom(s => s.Continent.ContinentName));

            CreateMap<Monument, MonumentDTO>();
        }
    }
}