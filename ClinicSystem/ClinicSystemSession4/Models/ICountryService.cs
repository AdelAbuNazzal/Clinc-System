using ClinicSystemSession4.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystemSession4.Models
{
    public interface ICountryService
    {
        List<Country> loadCountry();

        List<Country> loadCountryByName(string name);
        void Insert(Country country);
    }
}
