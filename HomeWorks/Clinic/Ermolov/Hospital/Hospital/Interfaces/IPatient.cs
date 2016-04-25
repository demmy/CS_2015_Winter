using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface IPatient
    {
        string Name { get; set; }
        string Complaint { get; set; }
        string Diagnosis { get; set; }
        string Recipe { get; set; }
    }
}
