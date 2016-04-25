using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public class InsuranceCompany : IInsuranceCompany
    {
        public List<InsuranceAccount> Clients { get; }
        public static event PayBillEvent BillIsPayed;

        public void AddClient(InsuranceAccount client)
        {
            Clients.Add(client);
        }

        public void PayBill(InsuranceAccount client , Bill bill)
        {
            BillIsPayed.Invoke(client);
        }
    }
}
