using ClinicSystemSession4.data;
using ClinicSystemSession4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystemSession4.Controllers
{
    public class CountryController : Controller
    {
        ICountryService countryService;

        public CountryController(ICountryService _countryService)
        {
            countryService = _countryService;
        }
        public IActionResult Index()
        {
            vmCountry vm = new vmCountry();
            vm.licountry = new List<Country>();
            return View("Index", vm);
        }

        public IActionResult search()
        {
            string name = Request.Form["txtSearchName"];
            List<Country> liCountry= countryService.loadCountryByName(name);
            vmCountry vm = new vmCountry();
            vm.licountry = liCountry;
            return View("Index",vm);
        }

        public IActionResult Save(vmCountry vm)
        {
            countryService.Insert(vm.country);
            vm.licountry = new List<Country>();
            return View("Index", vm);
        }
    }
}
