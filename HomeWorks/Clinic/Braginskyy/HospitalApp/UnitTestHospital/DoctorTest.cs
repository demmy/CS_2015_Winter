using System;
using NUnit.Framework;
using HospitalApp.Domain;
using HospitalApp.Entity.Doctors;
using Moq;

namespace UnitTestHospital
{
    [TestFixture]
    public class DoctorTest
    {
        private IDoctor doctorDentist;
        private IDoctor doctorENT;
        private IDoctor doctorOrthopedist;

        [SetUp]
        public void Setup()
        {
            doctorDentist = new Dentist();
            doctorENT = new ENT();
            doctorOrthopedist = new Orthopedist();
        }
        [Test]
        public void DentistPositivTest()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "jaw dislocated");            

            string prescription = doctorDentist.MedicalExamination(patient);

            Assert.That(prescription, Is.EqualTo("Straighten the jaw"));
        }
        [Test]
        public void DentistPositivTestWhithWrongSymptom()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "Wrong symptom");
            
            string prescription = doctorDentist.MedicalExamination(patient);

            Assert.That(prescription, Is.EqualTo(string.Empty));
        }
        [Test]
        public void DentistNegativTest()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "jaw dislocated");

            string prescription = doctorDentist.MedicalExamination(patient);

            Assert.That(prescription, Is.Not.EqualTo (string.Empty));
        }
        [Test]
        public void DentistNegativTestWhithWrongSymptom()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "Wrong symptom");

            string prescription = doctorDentist.MedicalExamination(patient);

            Assert.That(prescription, Is.Not.EqualTo("Straighten the jaw"));
        }
        [Test]
        public void ENTPositivTest()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "snot");

            string prescription = doctorENT.MedicalExamination(patient);

            Assert.That(prescription, Is.EqualTo("Antibiotics"));
        }
        [Test]
        public void ENTPositivTestWhithWrongSymptom()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "Wrong symptom");

            string prescription = doctorENT.MedicalExamination(patient);

            Assert.That(prescription, Is.EqualTo(string.Empty));
        }
        [Test]
        public void ENTNegativTest()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "snot");

            string prescription = doctorENT.MedicalExamination(patient);

            Assert.That(prescription, Is.Not.EqualTo(string.Empty));
        }
        [Test]
        public void ENTNegativTestWhithWrongSymptom()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "Wrong symptom");

            string prescription = doctorENT.MedicalExamination(patient);

            Assert.That(prescription, Is.Not.EqualTo("Antibiotics"));
        }
        [Test]
        public void OrthopedistPositivTest()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "fracture");

            string prescription = doctorOrthopedist.MedicalExamination(patient);

            Assert.That(prescription, Is.EqualTo("To set a plaster cast"));
        }
        [Test]
        public void OrthopedistPositivTestWhithWrongSymptom()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "Wrong symptom");

            string prescription = doctorOrthopedist.MedicalExamination(patient);

            Assert.That(prescription, Is.EqualTo(string.Empty));
        }
        [Test]
        public void OrthopedistNegativTest()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "fracture");

            string prescription = doctorOrthopedist.MedicalExamination(patient);

            Assert.That(prescription, Is.Not.EqualTo(string.Empty));
        }
        [Test]
        public void OrthopedistNegativTestWhithWrongSymptom()
        {
            IPatient patient = Mock.Of<IPatient>(d => d.Symptom == "Wrong symptom");

            string prescription = doctorOrthopedist.MedicalExamination(patient);

            Assert.That(prescription, Is.Not.EqualTo("To set a plaster cast"));
        }
    }
}
