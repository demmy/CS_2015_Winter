using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Doctors
{
    public class ENT : BaseDoctor
    {
        public ENT(string fullName) : base (fullName)
        {
            diagnosises = Constants.entDiagnosises;
        }
    }
}
