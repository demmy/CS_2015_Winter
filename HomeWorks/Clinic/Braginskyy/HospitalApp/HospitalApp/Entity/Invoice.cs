using HospitalApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp.Entity
{
    public class Invoice : IInvoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public IPatient Patient { get; set; }
        public string Receipt { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
    }
}
