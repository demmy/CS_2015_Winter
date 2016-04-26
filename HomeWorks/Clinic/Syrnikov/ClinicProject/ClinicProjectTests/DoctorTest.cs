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
    class DoctorTest
    {
        [Test]
        public void DoctorShouldReturnRightDiagnosis()
        {
            // arrange
            IDoctor testDoctor = new Orthopedist();
            IPatient testPatient = new Patient();
            testPatient.PatientComplaint.Symptoms.Add(Symptom.Headache);

            // act
            Diagnosis returnedDiagnosis = testDoctor.Diagnosticate(testPatient.PatientComplaint);

            // assert
            Assert.AreSame(new Diagnosis() , returnedDiagnosis);
        }

        [Test]
        public void DoctorShouldPrescribeRightTreatment()
        {
            // arrange
            IDoctor testDoctor = new Orthopedist();

            // act
            Treatment prescribedTreatment = testDoctor.PrescribeTreatment(new Diagnosis());

            // assert
            Assert.AreSame(new Treatment() , prescribedTreatment);
        }
    }
}
