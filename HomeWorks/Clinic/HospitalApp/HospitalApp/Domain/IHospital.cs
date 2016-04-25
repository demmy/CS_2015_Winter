using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Domain
{
    public interface IHospital
    {        
        void PatientReception(IPatient patient);        
        void Bill();
        void Treatment();
    }
}
