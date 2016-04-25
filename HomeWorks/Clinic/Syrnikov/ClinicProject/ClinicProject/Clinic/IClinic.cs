using System.Collections.Generic;

namespace ClinicProject
{
    public interface IClinic
    {
        decimal Balance { get; set; }
        List<IDoctor> Doctors { get; }
        List<IPatient> Patients { get; }

        void AddDoctor(IDoctor doctor);
        void AddPatient(IPatient patient);

        IDoctor GiveDoctor(IPatient patient);
        Bill GiveBill(Treatment appoitment);
        void Cure(IPatient patient , Diagnosis diagnosis , Treatment appoitment);
    }
}