using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travelAPI.Entities;

namespace travelAPI.Modules.Countries
{
    [Route("travelAPI/Country")]
    public class CountryController: ControllerBase
    {
        private readonly DatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public CountryController(DatabaseContext databaseContext, IMapper mapper)
        {
            _dbContext = databaseContext;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CountryDTO>> GetAll()
        {
            var countries = _dbContext
                .Country               
                .Include(c => c.Continent)
                .Include(c => c.Monuments)
                .ToList();

            var countriesDTO = _mapper.Map<List<CountryDTO>>(countries);

            return Ok(countriesDTO);
        }

        [HttpGet("{id}")]
        public ActionResult<CountryDTO> GetOne([FromRoute] int id)
        {
            var country = _dbContext
                .Country
                .Include(c => c.Continent)
                .Include(c => c.Monuments)
                .FirstOrDefault(c => c.Id == id);

            if (country is null)
                return NotFound();

            var countryDTO = _mapper.Map<CountryDTO>(country);

            return Ok(countryDTO);
        }
    }
}