using HospitalApp.Domain;
using HospitalApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Entity
{
    class Patient : IPatient
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Symptom { get; private set; }
        public IInsurance Insurance { get; private set; }
        
        public Patient(string name, int age, string symptom, IInsurance insurance)
        {
            Name = name;
            Age = age;
            Symptom = symptom;
            Insurance = insurance;
        }
        public Patient(string name, int age)
        {
            Name = name;
            Age = age;            
        }
    }
}
