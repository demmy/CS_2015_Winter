using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Domain
{
    public interface IInsurance
    {   
        void FootTheBill(IInvoice invoice);
        event EventHandler<ReportEventArgs> Report;
    }
}
