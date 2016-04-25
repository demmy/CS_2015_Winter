using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Interfaces
{
    public abstract class Person 
    {
        public Person(string fullName)
        {
            FullName = fullName;
        }

        public string FullName { get; private set; }
    }
}
