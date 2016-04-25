using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Interfaces;

namespace Clinica.Model
{
    class Policy:IPolicy
    {
        private string _series;
        private string _number;
        private IInsurance _insurance;
        private List<IServiceType> _serviceList;
        private IPatient _patient;

        public Policy(string series, string number, IInsurance insurance,
            List<IServiceType> serviceList, IPatient patient)
        {
            _series = series;
            _number = number;
            _insurance = insurance;
            _serviceList = serviceList;
            _patient = patient;
        }

        public string Series
        {
            get { return _series; }
        }

        public string Number
        {
            get { return _number; }
        }

        public IInsurance Insurance
        {
            get { return _insurance; }
        }

        public List<IServiceType> ServiceList
        {
            get { return _serviceList; }
        }

        public IPatient Patient
        {
            get { return _patient; }
        }

        public decimal Cost()
        {
            var services = (from p in _serviceList
                select p.Cost).ToArray();
            return services.Sum();
        }
    }
}
