using HospitalApp.Domain;
using HospitalApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IInsurance axa = new Insurance();            
            IPatient ivanov = new Patient("Ivanov", 25, "toothache", axa );            

            IHospital mechnikova = new Hospital();
            mechnikova.PatientReception(ivanov);

            Console.ReadLine();
        }
    }
}
