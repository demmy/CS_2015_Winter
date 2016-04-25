using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Interfaces;

namespace Clinica.Model
{
    class Department:IDepartment
    {
        private string _name;
        private readonly List<Doctor> _doctors = new List<Doctor>();
        public Department(string name)
        {
            _name = name;
        }  
        public void AddDoctor(Doctor doctor){
        doctor.SetDepartment(this);
        _doctors.Add(doctor);
        }
        public void RemoveDoctor(Doctor doctor){
        _doctors.Remove(doctor);
        }
        public void GetPay() { }
        public List<Doctor> GetDoctors(){
        return _doctors;
      }
    }
  }

