using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Model;

namespace Clinica.Interfaces
{
    interface IInsurance
    {
        void AddPolicy(IPolicy policy);
        void RemovePolicy(IPolicy policy);
        decimal Cost { get; set; }
        void Pay();
    }
}
