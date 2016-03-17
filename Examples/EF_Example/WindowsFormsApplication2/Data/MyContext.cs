using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.Domain;

namespace WindowsFormsApplication2.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
