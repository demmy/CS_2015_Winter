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
    class ClinicTests
    {
        [Test]
        public void AddDoctorTest()
        {
            // arrange
            IClinic testClinic = new Clinic();

            // act
            testClinic.AddDoctor(new Orthopedist());

            // assert
            Assert.IsNotNull(testClinic.Doctors);
        }

        [Test]
        public void AddPatientTest()
        {
            // arrange
            IClinic testClinic = new Clinic();

            // act
            testClinic.AddPatient(new Patient());

            // assert
            Assert.IsNotNull(testClinic.Patients);
        }

        [Test]
        public void ClinicShouldGiveRightDoctor()
        {
            // arrange
            IClinic testClinic = new Clinic();
            IPatient testPatient = new Patient();
            testPatient.PatientComplaint.Symptoms.Add(Symptom.Headache);

            // act
            IDoctor returnedDoctor = testClinic.GiveDoctor(testPatient);

            // assert
            Assert.IsTrue(returnedDoctor is Orthopedist);
        }

        [Test]
        public void ClinicShouldGiveBillForTreatment()
        {
            // arrange
            IClinic testClinic = new Clinic();
            IPatient testPatient = new Patient();
            testPatient.PatientComplaint.Symptoms.Add(Symptom.Headache);
            IDoctor testDoctor = testClinic.GiveDoctor(testPatient);
            Treatment testTreatment = testDoctor.PrescribeTreatment(testDoctor.Diagnosticate(testPatient.PatientComplaint));

            // act
            Bill returnedBill = testClinic.GiveBill(testTreatment);

            // assert
            Assert.IsNotNull(returnedBill);
        }

        [Test]
        public void ClinicShouldCure()
        {
            // arrange
            IClinic testClinic = new Clinic();
            IPatient testPatient = new Patient();
            testPatient.PatientComplaint.Symptoms.Add(Symptom.Headache);
            IDoctor testDoctor = testClinic.GiveDoctor(testPatient);
            Treatment testTreatment = testDoctor.PrescribeTreatment(testDoctor.Diagnosticate(testPatient.PatientComplaint));
            Bill returnedBill = testClinic.GiveBill(testTreatment);
            testPatient.PayBill();

            // act
            testClinic.Cure(testPatient, testDoctor.Diagnosticate(testPatient.PatientComplaint), testTreatment);

            // assert
            Assert.IsNull(testPatient.PatientComplaint.Symptoms);
        }


        [Test]
        public void UseCaseTest()
        {
            // arrange

            IClinic testClinic = new Clinic();
            IDoctor testDoctor = new Dentist();
            IPatient testPatient = new Patient();
            IInsuranceCompany testInsuranceCompany = new InsuranceCompany();
            testInsuranceCompany.Clients.Add(testPatient.Insurance);
            testClinic.AddDoctor(testDoctor);

            // act

            //Пациент приходит в больницу с жалобой
            testPatient.PatientComplaint.Symptoms.Add(Symptom.Headache);
            testClinic.AddPatient(testPatient);

            //Его направляют к нужному врачу(лор, ортопед, стоматолог).
            IDoctor doctorForPatient = testClinic.GiveDoctor(testClinic.Patients.LastOrDefault());

            //Доктор ставит диагноз и выписывает назначение. 
            Diagnosis diagnosisForPatient = doctorForPatient.Diagnosticate(testPatient.PatientComplaint);
            Treatment appointmentForPatient = doctorForPatient.PrescribeTreatment(diagnosisForPatient);

            //Больница выставляет счет страховой компании пациента.
            Bill billForPatient = testClinic.GiveBill(appointmentForPatient);

            //Страховая компания оплачивает счет.
            testPatient.PayBill();

            //После оплаты больница начинает лечение.
            testClinic.Cure(testPatient, diagnosisForPatient, appointmentForPatient);

            // assert
            Assert.IsNull(testPatient.PatientComplaint.Symptoms);
        }
    }
}
