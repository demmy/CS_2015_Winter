using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Doctors
{
    public class Podiatrist : BaseDoctor
    {
        public Podiatrist(string fullName) : base (fullName)
        {
            diagnosises = Constants.podiatristDiagnosises;
        }
    }
}
