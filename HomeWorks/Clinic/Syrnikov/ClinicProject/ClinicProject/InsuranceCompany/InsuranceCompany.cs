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

        public void AddClient(InsuranceAccount client)
        {
            Clients.Add(client);
        }

        public void PayBill(InsuranceAccount client , Bill bill , IClinic clinic)
        {
            if (bill.Sum <= client.Balance)
            {
                clinic.Balance += bill.Sum;
                client.Balance -= bill.Sum;
                bill.IsPayed = true;
            }
            else
            {
                bill.IsPayed = false;
            }
        }
    }
}
