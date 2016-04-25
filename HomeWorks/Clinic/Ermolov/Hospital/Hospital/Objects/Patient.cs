using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Objects
{
    class Patient : IPatient
    {
        public string Name { get; set; }
        public string Recipe { get; set; }
        public string Complaint { get; set; }
        public string Diagnosis { get; set; }
    }
}
