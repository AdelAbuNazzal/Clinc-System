using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicSystemSession4.data;
using ClinicSystemSession4.Models;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ClinicSystemSession4.Controllers
{
    public class PatientController : Controller
    {
        IConfiguration configuration;
        ICountryService countryService;
        IPatientService patientService;
        public PatientController(IConfiguration _Configuration, ICountryService _CountryService,IPatientService _PatientService)
        {
            configuration = _Configuration;
            countryService = _CountryService;
            patientService = _PatientService;
        }
        public IActionResult NewPatient()
        {
            List<Country> li = countryService.loadCountry();

            //CountryService service = new CountryService();
            //service.loadCountry();

            /*ClinicContext context = new ClinicContext();
            List<Country> li = (from cnt in context.country
                                select cnt).ToList();*/

            vmPatient vm = new vmPatient();
            vm.licountry = li;

            return View("NewPatient",vm);
        }

        public IActionResult PatientList()
        {
            List<Patient> li=new List<Patient>();
            return View("PatientList",li);
        }

        public IActionResult SavePatient(vmPatient vm)
        {
            string path = configuration["UploadPath"];

            if (ModelState.IsValid) { 
            string FilePath = Path.Combine(Directory.GetCurrentDirectory(), path, vm.patient.ProfilePic.FileName);
            vm.patient.ProfilePic.CopyTo(new FileStream(FilePath, FileMode.Create));
            vm.patient.Path = "http://localhost/ClinicSystemSession4/Upload/" + vm.patient.ProfilePic.FileName;

            patientService.Insert(vm.patient);
            }
            /*ClinicContext context = new ClinicContext();
            context.patient.Add(vm.patient);
            context.SaveChanges();*/

            //vm.licountry = new List<Country>();
            /*List<Country> li = (from cnt in context.country
                                select cnt).ToList();*/

            List<Country> li = countryService.loadCountry();
            
            vm.licountry = li;
            return View("NewPatient", vm);
        }

        public IActionResult SearchPatient()
        {
            string name = Request.Form["txtSearchName"];

            List<Patient> liPatient=patientService.LoadByName(name);
            //ClinicContext context = new ClinicContext();

            //List<Patient> liPatient = (from p in context.patient
            //                where p.Name == name
            //                select p).ToList();

            return View("PatientList", liPatient);
        }



    }
}
