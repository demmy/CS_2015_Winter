using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public enum Doctor
    {
        Unknown,
        Dentist,
        ENT,
        Podiatrist
    }

    public static class Constants
    {
        static Constants()
        {
            
            dentistDiagnosises = new Dictionary<string, string>
            {
                {"Dentistcomplaint1", "Dentistdiagnosise1"},
                {"Dentistcomplaint2", "Dentistdiagnosise2"},
                {"Dentistcomplaint3", "Dentistdiagnosise2"}
            };
            entDiagnosises = new Dictionary<string, string>
            {
                {"ENTcomplaint1", "ENTdiagnosise1"},
                {"ENTcomplaint2", "ENTdiagnosise1"},
                {"ENTcomplaint3", "ENTdiagnosise2"}
            };
            podiatristDiagnosises = new Dictionary<string, string>
            {
                {"Podiatristcomplaint1", "Podiatristdiagnosise1"},
                {"Podiatristcomplaint2", "Podiatristdiagnosise2"},
                {"Podiatristcomplaint3", "Podiatristdiagnosise2"}
            };
            hospitalComplaintsDoctors = new Dictionary<string, Doctor>
            {
                {"Dentistcomplaint1", Doctor.Dentist},
                {"Dentistcomplaint2", Doctor.Dentist},
                {"Dentistcomplaint3", Doctor.Dentist},
                {"ENTcomplaint1", Doctor.ENT},
                {"ENTcomplaint2", Doctor.ENT},
                {"ENTcomplaint3", Doctor.ENT},
                {"Podiatristcomplaint1", Doctor.Podiatrist},
                {"Podiatristcomplaint2", Doctor.Podiatrist},
                {"Podiatristcomplaint3", Doctor.Podiatrist}
            };
            hospitalTreatmentsBills = new Dictionary<string, decimal>
            {
                {"Dentistdiagnosise1", (decimal)200.00},
                {"Dentistdiagnosise2", (decimal)280.00},
                {"ENTdiagnosise1", (decimal)500.00},
                {"ENTdiagnosise2", (decimal)170.00},
                {"Podiatristdiagnosise1", (decimal)200.00},
                {"Podiatristdiagnosise2", (decimal)890.00}
            };

            InsuranceCaseLimit = new Dictionary<string, decimal>
            {
                {"Dentistdiagnosise1", (decimal)300.00},
                {"Dentistdiagnosise2", (decimal)380.00},
                {"ENTdiagnosise1", (decimal)600.00},
                {"ENTdiagnosise2", (decimal)270.00},
                {"Podiatristdiagnosise1", (decimal)300.00},
                {"Podiatristdiagnosise2", (decimal)790.00}
            };
        }

        public static Dictionary<string, string> dentistDiagnosises;

        public static Dictionary<string, string> entDiagnosises;

        public static Dictionary<string, string> podiatristDiagnosises;

        public static Dictionary<string, Doctor> hospitalComplaintsDoctors;

        public static Dictionary<string, decimal> hospitalTreatmentsBills;

        public static Dictionary<string, decimal> InsuranceCaseLimit;
    }
}
