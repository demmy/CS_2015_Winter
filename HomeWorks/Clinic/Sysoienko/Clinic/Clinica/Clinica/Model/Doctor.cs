using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Interfaces;

namespace Clinica.Model
{
   abstract class Doctor
    {
        private string _fullName;
        private IDiagnosis _diagnosis;
        List<IPatient> _patients = new List<IPatient>();
        IDepartment _department;        
        public Doctor(string fullName)
        {
            _fullName = fullName;
        }
        public string Name
        {
            get { return _fullName; }
        }

        public void AddPatient(IPatient patient)
        {
            _patients.Add(patient);
        }
        public void RemovePatient(IPatient patient)
        {
            _patients.Add(patient);
        }

        public List<IPatient> GetPatients
        {
            get { return _patients; }
        }

        public void SetDepartment(IDepartment hospital)
        {
            _department = hospital;
        }
        public IDepartment GetDepartment()
        {
            return _department;
        }
        public void Healing()
        {

        }
        public void MakeDiagnosis()
        {
        }

       public abstract void MakeDiagnosis(IDiagnosis diagnosis);
       public abstract void WriteAppointment();
    }
    class Otorhinolaryngolog : Doctor
    {
        public Otorhinolaryngolog(string fullName) : base(fullName)
        {
        }

        public override void MakeDiagnosis(IDiagnosis diagnosis)
        {
            throw new NotImplementedException();
        }

        public override void WriteAppointment()
        {
            throw new NotImplementedException();
        }
    }

    class Orthopedist : Doctor
    {
        public Orthopedist(string fullName) : base(fullName)
        {
        }

        public override void MakeDiagnosis(IDiagnosis diagnosis)
        {
            throw new NotImplementedException();
        }

        public override void WriteAppointment()
        {
            throw new NotImplementedException();
        }
    }

    class Dentist : Doctor
    {
        public Dentist(string fullName) : base(fullName)
        {
        }
        public override void MakeDiagnosis(IDiagnosis diagnosis)
        {
            throw new NotImplementedException();
        }
        public override void WriteAppointment()
        {
            throw new NotImplementedException();
        }
    }
}
