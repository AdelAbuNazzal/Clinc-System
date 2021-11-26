using ClinicSystemSession4.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystemSession4.Models
{
    public interface IPatientService
    {
        void Insert(Patient patient);

        List<Patient> LoadByName(string name);
    }
}
