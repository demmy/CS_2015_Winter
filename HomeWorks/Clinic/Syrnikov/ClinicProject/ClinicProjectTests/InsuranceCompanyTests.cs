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
    class InsuranceCompanyTests
    { 
        [Test]
        public void AddClientTest()
        {
            // arrange
            IInsuranceCompany testInsuranceCompany = new InsuranceCompany();

            // act
            InsuranceAccount testClient = new InsuranceAccount();
            testInsuranceCompany.AddClient(testClient);

            // assert
            Assert.AreSame(testClient, testInsuranceCompany.Clients.LastOrDefault());
        }

        [Test]
        public void InsurenceCompanyShouldPayBill()
        {
            // arrange
            IInsuranceCompany testInsuranceCompany = new InsuranceCompany();
            InsuranceAccount testClient = new InsuranceAccount();
            testInsuranceCompany.AddClient(testClient);
            decimal oldBalance = testInsuranceCompany.Clients.LastOrDefault().Balance;

            // act
            testInsuranceCompany.PayBill(testInsuranceCompany.Clients.LastOrDefault(), new Bill());

            // assert
            Assert.IsTrue(oldBalance > testInsuranceCompany.Clients.LastOrDefault().Balance);
        }
    }
}
