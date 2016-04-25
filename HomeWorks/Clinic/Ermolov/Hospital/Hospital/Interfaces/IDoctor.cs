using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface IDoctor
    {
        void Diagnostics(IPatient patient);
        void GiveRecipe(IPatient patient);
        void Cure(IPatient patient);
    }
}
