using ClinicSystemSession4.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystemSession4.Models
{
    public class vmCountry
    {
        public Country country { get; set; }
        public List<Country> licountry { get; set; }
    }
}
