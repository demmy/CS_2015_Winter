using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Interfaces;

namespace Clinica.Model
{
    class ServiceType:IServiceType
    {
        private string _name;
        private string _code;
        private decimal _cost;

        public ServiceType()
        {
        }

        public ServiceType(string name, string code, decimal cost)
        {
            _name = name;
            _code = code;
            _cost = cost;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Code
        {
            get { return _code; }
        }

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
    }
}
