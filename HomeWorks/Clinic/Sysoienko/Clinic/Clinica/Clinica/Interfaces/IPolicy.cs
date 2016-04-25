using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Model;

namespace Clinica.Interfaces
{
    interface IPolicy
    {
        string Number { get; }
        string Series { get; }
        IPatient Patient { get; }
        decimal Cost();
    }
}
