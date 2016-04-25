using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Interfaces;

namespace Clinica.Model
{
    class Insurance:IInsurance
    {
        private string _companyName;
        private Command _command;
        List<IPolicy> _policies = new List<IPolicy>();  
        public Insurance(string companyName)
        {
            _companyName = companyName;
        }

        public void SetCommand(Command command)
        {
            _command = command;
        }
        public void AddPolicy(IPolicy policy)
        {
            _policies.Add(policy);
        }
        public void RemovePolicy(IPolicy policy)
        {
            _policies.Remove(policy);
        }
        public string CompanyName
        {
            get { return _companyName; }
        }

        public void Pay()
        {
            _command.Execute();
            Cost = 0;
        }
        public decimal Cost { get; set; }
    }
}
