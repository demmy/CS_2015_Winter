using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Domain
{
    public interface IPatient
    {
        string Name { get; }
        int Age { get; }
        string Symptom { get; }
        IInsurance Insurance { get; }        
    }
}
