using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Objects
{
    class InsuranceCompany : IInsuranceCompany
    {
        public delegate void InvoicePaid();
        public event InvoicePaid onInvoicePaid;

        public void Paying(IInvoice invoice)
        {
            invoice.Paid = true;
            if (onInvoicePaid != null)
            {
                onInvoicePaid();
            }
        }
    }
}
