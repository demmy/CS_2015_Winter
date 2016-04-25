using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Clinica.Interfaces;
using Clinica.Model;

namespace Clinica
{
    class Program
    {
        static void Main(string[] args)
        {
            var patient = new Patient("","");
            var department = new Department("");
            var doctor = new Dentist("");
            doctor.AddPatient(patient);
            department.AddDoctor(doctor);
            var insurance = new Insurance("");
            var serviceType1 = new ServiceType("Plombing","2231", 1000);
            var serviceType2 = new ServiceType("Cleaning", "2231", 500);
            var serviceList = new List<IServiceType> {serviceType1, serviceType2};
            var policy = new Policy("xddf-23", "0032", insurance, serviceList, patient);
            insurance.AddPolicy(policy);
            doctor.MakeDiagnosis();
            doctor.WriteAppointment();
            insurance.Cost = policy.Cost();

            var command = new PayCommand(department);   
            insurance.SetCommand(command);
            insurance.Pay();
            doctor.Healing();
            insurance.RemovePolicy(policy);
            Console.ReadLine();
        }
    }
}
