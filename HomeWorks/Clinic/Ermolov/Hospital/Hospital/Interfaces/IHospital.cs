using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hospital.Hospital;

namespace Hospital.Interfaces
{
    interface IHospital
    {
        void DoctorVisit(IPatient patient);
        void Healing();
        IInvoice GetInvoice();
    }
}
