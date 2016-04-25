using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hospital.Objects.InsuranceCompany;

namespace Hospital.Interfaces
{
    interface IInsuranceCompany
    {
        void Paying(IInvoice invoice);
        event InvoicePaid onInvoicePaid;
    }
}
