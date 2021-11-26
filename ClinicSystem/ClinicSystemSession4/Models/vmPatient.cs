using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicSystemSession4.data;
using Microsoft.AspNetCore.Http;

namespace ClinicSystemSession4.Models
{
    public class vmPatient
    {
        public Patient patient { get; set; }
        public List<Country> licountry { get; set; }

    }
}
