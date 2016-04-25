using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Objects.Doctor
{
     abstract class StaffRoom
    {
        public abstract Doctor Request();
    }

    class Orthopaedist : StaffRoom
    {
        public override Doctor Request()
        {
            return new DoctorOrthopadeist();
        }
    }

    class Otolaryngologist : StaffRoom
    {
        public override Doctor Request()
        {
            return new DoctorOtolaryngologist();
        }
    }

    class Dentist : StaffRoom
    {
        public override Doctor Request()
        {
            return new DoctorDentist();
        }
    }
}
