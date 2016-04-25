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
    class Hospital : IHospital
    {
        IDoctor doctor;
        IPatient patient;

        public Hospital(IPatient patient)
        {
            this.patient = patient;
            StaffRoom doctors = new Orthopaedist();
            doctor = doctors.Request();
        }
        public void DoctorVisit(IPatient patient)
        {
            doctor.Diagnostics(patient);
            doctor.GiveRecipe(patient);
        }

        public IInvoice GetInvoice()
        {
            Random rnd = new Random(10000);
            IInvoice invoice = new Invoice
            {
                Id = rnd.Next(),
                PatientName = patient.Name,
                SumToPay = rnd.Next()
            };
            return invoice;
        }

        public void Healing()
        {
            Console.WriteLine();
            Console.WriteLine("Healing...");
            doctor.Cure(this.patient);
        }
    }
}
