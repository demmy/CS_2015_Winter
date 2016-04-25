using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public interface IInsuranceCompany
    {
        List<InsuranceAccount> Clients { get; }

        void AddClient(InsuranceAccount client);
        void PayBill(InsuranceAccount client , Bill bill , IClinic clinic);
    }
}
