using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public delegate void PayBillEvent(InsuranceAccount account);
    public interface IInsuranceCompany
    {
        List<InsuranceAccount> Clients { get; }

        void AddClient(InsuranceAccount client);
        void PayBill(InsuranceAccount client , Bill bill);
    }
}
