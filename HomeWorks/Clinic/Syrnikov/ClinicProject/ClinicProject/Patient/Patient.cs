using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public class Patient : Human , IPatient
    {
        public Bill PatientBill { get; set; }

        public Complaint PatientComplaint { get; set; }

        public void PayBill()
        {
            // use InsuranceCompany?
        }
    }
}
