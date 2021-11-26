using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using ClinicSystemSession4.helpers;

namespace ClinicSystemSession4.data
{
    [Table("Patients")]
    public class Patient
    {
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; }

        [BDateValidation]
        public DateTime? BDate { get; set; }

        [ForeignKey("country")]
        public int Country_Id { get; set; }

        [Required]
        public string Gender { get; set; }

        public Country country { get; set; }

        public string Path { get; set; }


        [NotMapped]
        public IFormFile ProfilePic { get; set; }

    }
}
