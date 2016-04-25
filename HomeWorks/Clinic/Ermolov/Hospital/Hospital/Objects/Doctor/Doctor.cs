using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Objects.Doctor
{
    abstract class Doctor : IDoctor
    {
        public abstract void Diagnostics(IPatient patient);
        public abstract void GiveRecipe(IPatient patient);
        public abstract void Cure(IPatient patient);
    }
}
