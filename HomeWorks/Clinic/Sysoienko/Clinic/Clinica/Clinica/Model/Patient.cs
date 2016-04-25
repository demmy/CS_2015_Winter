using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Interfaces;

namespace Clinica.Model
{
    class Patient:IPatient
    {
        private string _fullName;
        private string _complaint;
        public Patient(string fullName,string complaint)
        {
            _fullName = fullName;
            _complaint = complaint;
        }
        public string Complaint { get { return _complaint; } }
        public string Name
        {
            get { return _fullName; }
        }
    }
}
