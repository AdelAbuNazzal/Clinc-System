using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystemSession4.data
{
    [Table("Countries")]
    public class Country
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Patient> liPatient { get; set; }
    }
}
