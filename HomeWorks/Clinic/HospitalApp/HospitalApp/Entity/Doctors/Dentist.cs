using HospitalApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Entity.Doctors
{
    public class Dentist : IDoctor
    {
        private Dictionary<string, string> dentistPrescriptionsBook;
        public Dentist()
        {
            dentistPrescriptionsBook = Setup.dentistPrescriptionsBook;
        }      

        public string MedicalExamination(IPatient patient)
        {
            string prescription;
            if (dentistPrescriptionsBook.TryGetValue(patient.Symptom, out prescription))
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
