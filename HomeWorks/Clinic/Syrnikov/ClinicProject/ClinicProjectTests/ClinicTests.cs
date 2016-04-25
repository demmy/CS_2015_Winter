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
            testInsuranceCompany.PayBill(testPatient.Insurance, billForPatient);
            //testPatient.PayBill();

            //После оплаты больница начинает лечение.
            testClinic.Cure(testPatient, diagnosisForPatient, appointmentForPatient);

            // assert
            

        }
    }
}
