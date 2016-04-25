using HospitalApp.Domain;
using HospitalApp.Entity;
using HospitalApp.Entity.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public static class Setup
    {
        static readonly IDoctor dentist;
        static readonly IDoctor ENT;
        static readonly IDoctor orthopedist;
        public static List<IPatient> clients;
        public static Dictionary<string, IDoctor> symptomsBook;
        public static Dictionary<string, int> priceBook;
        public static Dictionary<string, string> dentistPrescriptionsBook;
        public static Dictionary<string, string> entPrescriptionsBook;
        public static Dictionary<string, string> orthopedistPrescriptionsBook;
        static Setup()
        {
            dentistPrescriptionsBook = new Dictionary<string, string>
            {
                {"toothache","Pull teeth"},
                {"jaw dislocated", "Straighten the jaw"}
            };
            entPrescriptionsBook = new Dictionary<string, string>
            {
                {"cold","Mustard plaster"},
                {"deafness", "Drip drops"},
                {"snot", "Antibiotics"}

            };
            orthopedistPrescriptionsBook = new Dictionary<string, string>
            {
                {"fracture","To set a plaster cast"},
                {"dislocation", "Straighten the joint"}
            };

            dentist = new Dentist();
            ENT = new ENT();
            orthopedist = new Orthopedist();

            clients = new List<IPatient>
            {
                new Patient("Ivanov", 25),
                new Patient("Petrov", 21),
                new Patient("Sydorov", 32)
            };                 
            symptomsBook = new Dictionary<string, IDoctor>
            {
                {"toothache",dentist},
                {"cold", ENT},
                {"fracture", orthopedist},
                {"deafness", ENT},
                {"dislocation", orthopedist},
                {"jaw dislocated", dentist},
                {"snot", ENT}                
            };
            priceBook = new Dictionary<string, int>
            {
                {"Pull teeth",50},
                {"Mustard plaster", 30},
                {"To set a plaster cast", 120},
                {"Drip drops", 70},
                {"Straighten the joint", 110},
                {"Straighten the jaw", 210},
                {"Antibiotics",10}                
            };
        }
    }
}
