using HospitalApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Entity.Doctors
{
    public class Orthopedist : IDoctor
    {
        private Dictionary<string, string> orthopedistPrescriptionsBook;
        public Orthopedist()
        {
            orthopedistPrescriptionsBook = Setup.orthopedistPrescriptionsBook;
        }      

        public string MedicalExamination(IPatient patient)
        {
            string prescription;
            if (orthopedistPrescriptionsBook.TryGetValue(patient.Symptom, out prescription))
            {
                Console.WriteLine("The Dentist wrote out a prescription");
                return prescription;
            }
            else
            {
                Console.WriteLine("We can not cure you");
                return string.Empty;
            }
        }
    }
}
