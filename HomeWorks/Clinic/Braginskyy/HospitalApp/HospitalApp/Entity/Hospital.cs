using HospitalApp.Domain;
using HospitalApp.Entity.Doctors;
using HospitalApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Entity
{
    public class Hospital : IHospital
    {        
        private IPatient patient;        
        private IInsurance insurances;      
        private Dictionary<string, IDoctor> symptomsBook;
        private Dictionary<string, int> priceBook;
        private List<IInvoice> invoceList;
        private IInvoice invoice;
        private IDoctor currentDoctor;
        private string prescription;
        private int price;
        private int invoiceId;

        public Hospital()
        {          
            symptomsBook = Setup.symptomsBook;
            priceBook = Setup.priceBook;
            invoceList = new List<IInvoice>();
        }
        public void PatientReception(IPatient patient)
        {
            this.patient = patient;
            this.insurances = patient.Insurance;
            insurances.Report += insurances_Report;
            PrimaryExamination();            
        } 
        public void Bill()
        {
            invoiceId++;
            invoice = new Invoice() { Id = invoiceId, Date = DateTime.Now, Patient = patient, Receipt = prescription, Price = price,Status = false};
            invoceList.Add(invoice);            
            Console.WriteLine("Hospital billed the insurance company");
            insurances.FootTheBill(invoice);
        }
        public void Treatment()
        {
            Console.WriteLine("Treatment is started");
        }
        void insurances_Report(object sender, ReportEventArgs e)
        {
            if (e.Report.Status == true)
            {
                Console.WriteLine("Payment accepted");
                invoceList.Find(x => x.Id == e.Report.Id).Status = true;
                Treatment();
            }
        }
        private void CostOfTreatment(string receipt)
        {
            if (priceBook.TryGetValue(prescription, out price))
            {
                Console.WriteLine("Hospital treatment costs considered");
                Bill();
            }
            else
            {
                Console.WriteLine("We can not give you an invoice.");
            }
        }
        private void PrimaryExamination()
        {
            if (symptomsBook.TryGetValue(patient.Symptom, out  currentDoctor))
            {
                Console.WriteLine("The patient is sent to the doctor");
                prescription = currentDoctor.MedicalExamination(patient);
                if (prescription != string.Empty)
                {
                    CostOfTreatment(prescription); 
                }                
            }
            else
            {
                Console.WriteLine("We don't have such a doctor.");
            } 
        }       
    }
}
