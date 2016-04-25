using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Interfaces
{
    public interface IInsuranceCompany
    {
        void AddClient(Person client);
        void AddRangeClients(List<Person> clients);
        void BillPayment(ref Bill bill);
    }
}
