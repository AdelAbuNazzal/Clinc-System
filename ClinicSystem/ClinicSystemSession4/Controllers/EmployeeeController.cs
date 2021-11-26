using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicSystemSession4.Models;
namespace ClinicSystemSession4.Controllers
{
    public class EmployeeeController : Controller
    {
        ICountryService countryServices;
        public EmployeeeController(ICountryService _CountryService)
        {
            countryServices = _CountryService;
        }
        public IActionResult Index()
        {
            countryServices.loadCountry();

            return View();
        }


    }
}
