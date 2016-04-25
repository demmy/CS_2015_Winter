using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Doctors
{
    public class Dentist : BaseDoctor
    {
        public Dentist(string fullName) : base (fullName)
        {
            diagnosises = Constants.dentistDiagnosises;
        }
    }
}
