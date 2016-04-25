using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hospital.Hospital;

namespace Hospital.Interfaces
{
    interface IInvoice
    {
        int Id { get; set; }
        string PatientName { get; set; }
        decimal SumToPay { get; set; }
        bool Paid { get; set; }
    }
}
