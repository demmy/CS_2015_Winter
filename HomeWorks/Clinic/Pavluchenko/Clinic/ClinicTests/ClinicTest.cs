using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using Clinic.Interfaces;
using Clinic;
using Clinic.Doctors;

namespace ClinicTests
{
    [TestFixture]
    public class ClinicTest
    {
        IHospital hospital;
        IInsuranceCompany insuranceCompany;
        Patient patient1;
        Patient patient2;
        Patient patient3;
        Patient patient4;
        Dentist dentist;
        ENT ent;
        Podiatrist podiatrist;
        Bill currentBill;

        [SetUp]
        public void SetUp()
        {
            patient1 = new Patient("John Doe1", "Podiatristcomplaint3");
            patient2 = new Patient("John Doe2", "Dentistcomplaint2");
            patient3 = new Patient("John Doe3", "ENTcomplaint1");
            patient4 = new Patient("John Doe4", "Pain simulation");

            dentist = new Dentist("Brian Smith");
            ent = new ENT("Colin Johnson");
            podiatrist = new Podiatrist("Dominic Taylor");
            List<BaseDoctor> doctors = new List<BaseDoctor> { dentist, ent, podiatrist }; 

            hospital = new Hospital();
            hospital.AddRangeDoctors(doctors);

            insuranceCompany = new InsuranceCompany();
            List<Person> clients = new List<Person> { patient1, patient2, patient3, patient4 };
            insuranceCompany.AddRangeClients(clients);
        }

        [Test]
        public void HospiralReception()
        {
            hospital.Reception(patient1);
            BaseDoctor currentDoctor = hospital.CurrentDoctor;
            Assert.AreEqual(currentDoctor, podiatrist);

            hospital.Reception(patient2);
            currentDoctor = hospital.CurrentDoctor;
            Assert.AreEqual(currentDoctor, dentist);

            hospital.Reception(patient4);
            currentDoctor = hospital.CurrentDoctor;
            Assert.AreEqual(null , currentDoctor);
        }

        [Test]
        public void ActualityTreatment()
        {
            hospital.Reception(patient2);
            string treatment = hospital.CurrentTreatment;
            Assert.AreEqual("Dentistdiagnosise2", treatment);

            hospital.Reception(patient3);
            treatment = hospital.CurrentTreatment;
            Assert.AreEqual("ENTdiagnosise1", treatment);

            hospital.Reception(patient4);
            treatment = hospital.CurrentTreatment;
            Assert.AreEqual("", treatment);
        }

        [Test]
        public void SumForTreatment()
        {
            hospital.Reception(patient1);
            currentBill = hospital.CreateBill();
            decimal sum = currentBill.Sum;
            Assert.AreEqual(sum, 890.00);

            hospital.Reception(patient3);
            currentBill = hospital.CreateBill();
            sum = currentBill.Sum;
            Assert.AreEqual(sum, 500.00);

            hospital.Reception(patient4);
            currentBill = hospital.CreateBill();
            sum = currentBill.Sum;
            Assert.AreEqual(sum, 0.00);
        }

        [Test]
        public void UseCase()
        {
            hospital.Reception(patient2);
            currentBill = hospital.CreateBill();
            insuranceCompany.BillPayment(ref currentBill);
            hospital.ChecBill(currentBill);
            string complaint = patient2.Complaint;
            string billStatus = currentBill.Status;
            Assert.AreEqual("Paid", billStatus);
            Assert.AreEqual("No complaints", complaint);

            hospital.Reception(patient1);
            currentBill = hospital.CreateBill();
            insuranceCompany.BillPayment(ref currentBill);
            hospital.ChecBill(currentBill);
            complaint = patient1.Complaint;
            billStatus = currentBill.Status;
            Assert.AreEqual("Not paid. Shortfall is 100", billStatus);
            Assert.AreEqual("Podiatristcomplaint3", complaint);

            hospital.Reception(patient4);
            currentBill = hospital.CreateBill();
            insuranceCompany.BillPayment(ref currentBill);
            hospital.ChecBill(currentBill);
            complaint = patient4.Complaint;
            billStatus = currentBill.Status;
            Assert.AreEqual("Not paid.", billStatus);
            Assert.AreEqual("Pain simulation", complaint);
        }
    }
}
