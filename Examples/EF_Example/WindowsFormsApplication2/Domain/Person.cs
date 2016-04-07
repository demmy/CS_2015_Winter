using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Address Address { get; set; }
    }
}
