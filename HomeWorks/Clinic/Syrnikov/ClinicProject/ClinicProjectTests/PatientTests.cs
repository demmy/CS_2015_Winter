using ClinicProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProjectTests
{
    [TestFixture]
    class PatientTests
    {
        [SetUp]
        public void SetUp()
        {
            IClinic testClinic = new Clinic();
            IDoctor testDoctor = new Dentist();
            IPatient testPatient = new Patient();
            testClinic.AddDoctor(testDoctor);
            testClinic.AddPatient(testPatient);
        }

        [Test]
        public void CreatePatientTest()
        {
            // arrange

            // act

            // assert
        }

        [Test]
        public void PayBillTest()
        {
            // arrange
            IPatient testPatient = new Patient();
            // act
            testPatient.PatientBill = new Bill();
            testPatient.PayBill();

            // assert
            Assert.IsTrue(testPatient.PatientBill.IsPayed);

        }
    }
}
