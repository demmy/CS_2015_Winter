using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Interfaces;

namespace Hospital.Objects.Doctor
{
    class DoctorOrthopadeist : Doctor
    {
        public override void Cure(IPatient patient)
        {
            patient.Diagnosis = "Healthful";
        }

        public override void Diagnostics(IPatient patient)
        {
            patient.Diagnosis = "Flat-foot";
        }

        public override void GiveRecipe(IPatient patient)
        {
            patient.Recipe = "Wash with holy water";
        }
    }
}
