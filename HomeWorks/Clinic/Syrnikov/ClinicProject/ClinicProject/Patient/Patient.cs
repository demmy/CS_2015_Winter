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

        public Patient()
        {
            InsuranceCompany.BillIsPayed += BillIsPayed;
        }

        public void PayBill()
        {
            // use InsuranceCompany
        }

        private void BillIsPayed(InsuranceAccount account)
        {
            PatientBill.IsPayed = true;
        }
    }
}
