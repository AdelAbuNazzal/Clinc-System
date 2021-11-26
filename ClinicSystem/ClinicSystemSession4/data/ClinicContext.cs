using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClinicSystemSession4.data
{
    public class ClinicContext:DbContext
    {
        IConfiguration configuration;
        public ClinicContext(IConfiguration _Configuration)
        {
            configuration = _Configuration;
        }

        public DbSet<Country> country { get; set; }
        public DbSet<Patient> patient { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ClinicConnection"));
            //optionsBuilder.UseSqlServer("data source=localhost; initial catalog=ClinicDb4;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
