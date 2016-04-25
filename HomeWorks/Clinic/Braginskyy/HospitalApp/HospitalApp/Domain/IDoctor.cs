using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Domain
{
    public interface IDoctor
    {             
        string MedicalExamination(IPatient patient);       
    }
}
