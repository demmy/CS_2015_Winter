using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Domain
{
    public interface IInvoice
    {
        int Id { get; set; }
        DateTime Date { get; set; }        
        IPatient Patient { get; set; }        
        string Receipt { get; set; }
        int Price { get; set; }
        bool Status { get; set; }
    }
}
