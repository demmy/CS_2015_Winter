using System;
using System.Collections.Generic;

namespace ClinicProject
{
    public class Clinic : IClinic
    {
        public decimal Balance { get; set; }
        public List<IDoctor> Doctors { get; }
        public List<IPatient> Patients { get; }       

        public void AddDoctor(IDoctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void AddPatient(IPatient patient)
        {
            Patients.Add(patient);
        }

        public IDoctor GiveDoctor(IPatient patient)
        {
            IDoctor doctor = null;
            // magic
            return doctor;
        }

        public Bill GiveBill(Treatment appoitment)
        {
            return new Bill();
        }

        public void Cure(IPatient patient, Diagnosis diagnosis, Treatment appoitment)
        {
            if (patient.PatientBill.IsPayed)
            {
                // magic
            }
        }

        
    }
}