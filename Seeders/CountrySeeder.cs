using System.Collections.Generic;
using System.Linq;
using travelAPI.Entities;

namespace travelAPI.Seeders
{
    public class CountrySeeder
    {
        private readonly DatabaseContext _dbContext;
        public CountrySeeder(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Country.Any())
                {
                    var countries = GetCountries();
                    _dbContext.Country.AddRange(countries);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Country> GetCountries()
        {
            var countries = new List<Country>()
            {
                new Country()
                {
                    CountryName = "Polska",
                    Capitol = "Warszawa",
                    Population = 40000000,
                    Area = 39000,
                    CountryDescription = "Opis Polski",
                    Continent = new Continent()
                    {
                        ContinentName = "Europa"
                    },
                    Monuments = new List<Monument>()
                    {
                        new Monument()
                        {
                            MonumentName = "Zamek w Malborku"
                        },

                        new Monument()
                        {
                            MonumentName = "Wawel"
                        }
                    }
                },

                new Country()
                {
                    CountryName = "Japonia",
                    Capitol = "Tokio",
                    Continent = new Continent()
                    {
                        ContinentName = "Azja",
                        ContinentDescription = "Opis Azji"
                    },
                    Monuments = new List<Monument>()
                    {
                        new Monument()
                        {
                            MonumentName = "Złota świątynia",
                            MonumentDescription = "Opis świątyni",
                        }
                    }
                }
            };
            return countries;
        }
    }
}