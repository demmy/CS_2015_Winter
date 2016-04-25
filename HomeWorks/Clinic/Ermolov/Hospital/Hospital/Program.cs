using Hospital.Interfaces;
using Hospital.Objects;
using Hospital.Objects.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            IPatient patient = new Patient
            {
                Name = "John Wick",
                Complaint = "I can't run fast!",
                Diagnosis = "Not viewed",
                Recipe = "Not writed"
            };
            IInsuranceCompany insuranceCompany = new InsuranceCompany();
            Console.WriteLine("*** Clinic of \"Eternal Rest\" greeting You! ***");
            Console.WriteLine();

            IHospital hospital = new Hospital(patient);
            Console.WriteLine("Name: {0}", patient.Name);
            Console.WriteLine("Complaint: {0}", patient.Complaint);
            Console.WriteLine();
            hospital.DoctorVisit(patient);
            Console.WriteLine("{0}, your diagnosis is \"{1}\".", patient.Name, patient.Diagnosis);
            Console.WriteLine("Recipe: {0}.", patient.Recipe);
            insuranceCompany.onInvoicePaid += hospital.Healing;
            Console.WriteLine("Invoice is sended to your Insurance Company... waiting for payment...");
            insuranceCompany.Paying(hospital.GetInvoice());

            Console.WriteLine();
            Console.WriteLine("Your current diagnosis is \"{0}\".", patient.Diagnosis);
            Console.Read();
        }

    }
}
