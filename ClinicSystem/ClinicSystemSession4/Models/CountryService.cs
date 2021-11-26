using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicSystemSession4.data;

namespace ClinicSystemSession4.Models
{
    public class CountryService:ICountryService
    {
        ClinicContext clinicContext;

        public CountryService(ClinicContext _ClinicContext)
        {
            clinicContext = _ClinicContext;
        }
        public List<Country> loadCountry()
        {
            
            List<Country> li = (from cnt in clinicContext.country
                                select cnt).ToList();
            return li;
        }


        public List<Country> loadCountryByName(string name)
        {

            List<Country> li = (from cnt in clinicContext.country
                                where cnt.Name== name
                                select cnt).ToList();
            return li;
        }

        public void Insert(Country country)
        {
            clinicContext.country.Add(country);
            clinicContext.SaveChanges();

        }
    }
}
