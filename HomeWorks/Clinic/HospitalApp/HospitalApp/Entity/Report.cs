using HospitalApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Entity
{
    public class Report : IReport
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
