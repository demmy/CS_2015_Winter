using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Doctors
{
    public abstract class BaseDoctor: Person
    {
        protected Dictionary<string, string> diagnosises;
        protected string currentTreatment;

        public BaseDoctor(string fullName) : base (fullName)
        {

        }

        public string Diagnosise(Patient patient)
        {
            currentTreatment = string.Empty;
            foreach (var item in diagnosises)
            {
                if (item.Key == patient.Complaint)
                {
                    currentTreatment = item.Value;
                    break;
                }
            }
            return currentTreatment;
        }

        public void Treatment(ref Patient patient)
        {
            patient.Complaint = "Actual treatment";
        }

    }
}
