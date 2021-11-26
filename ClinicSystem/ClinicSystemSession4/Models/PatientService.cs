using ClinicSystemSession4.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystemSession4.Models
{
    public class PatientService:IPatientService
    {
        ClinicContext clinicContext;
        public PatientService(ClinicContext _clinicContext)
        {
            clinicContext = _clinicContext;
        }

        public void Insert(Patient patient)
        {
            // ClinicContext context = new ClinicContext();
            clinicContext.patient.Add(patient);
            clinicContext.SaveChanges();
        }

        public List<Patient> LoadByName(string name)
        {
            //ClinicContext context = new ClinicContext();
            List<Patient> liPatient = (from p in clinicContext.patient
                                       where p.Name == name
                                       select p).ToList();
            return liPatient;
        }
    }
}
