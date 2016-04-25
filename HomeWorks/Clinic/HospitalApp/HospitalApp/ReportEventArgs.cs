using HospitalApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class ReportEventArgs : EventArgs
    {
        public IReport Report { get; private set; }
        public ReportEventArgs(IReport report)
        {
            Report = report; 
        }
    }
}
