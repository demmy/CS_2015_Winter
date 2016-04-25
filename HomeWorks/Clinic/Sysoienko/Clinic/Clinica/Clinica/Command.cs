using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Interfaces;
using Clinica.Model;

namespace Clinica
{
   abstract class Command
   {
       public abstract void Execute();
       public abstract void Undo();
   }

    class PayCommand : Command
    {
        private IDepartment _department;

        public PayCommand(IDepartment department)
        {
            _department = department;
        }
        public override void Execute()
        {
            _department.GetPay();
        }
        public override void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
