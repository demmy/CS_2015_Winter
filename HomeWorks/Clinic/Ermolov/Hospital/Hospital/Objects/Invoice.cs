using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Objects
{
    class Invoice : IInvoice
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public decimal SumToPay { get; set; }
        public bool Paid { get; set; }
    }
}
