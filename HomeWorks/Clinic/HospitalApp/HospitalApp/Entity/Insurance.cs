using HospitalApp.Domain;
using HospitalApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Entity
{
    public class Insurance : IInsurance
    {
        private List<IPatient> clients;
        private IReport report;
        public Insurance()
        {
            clients = Setup.clients;
        }
        public void FootTheBill(IInvoice invoice)
        {
            if (clients.Find(x=> x.Name == invoice.Patient.Name)!=null)
            {
                report = new Report() { Id = invoice.Id, Date = DateTime.Now, Status = true };
                Console.WriteLine("The bill is paid");
                if (Report != null) { Report(this, new ReportEventArgs(report)); }
            }           
            else
            {
                report = new Report() { Id = invoice.Id, Date = DateTime.Now, Status = false }; 
                Console.WriteLine("The invoice is not paid, we do not have such a client");
                if (Report != null) { Report(this, new ReportEventArgs(report)); } 
            }
        }
        public event EventHandler<ReportEventArgs> Report;
    }
}
