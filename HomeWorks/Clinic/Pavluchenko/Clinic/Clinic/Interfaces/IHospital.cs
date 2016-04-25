using Clinic.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Interfaces
{
    public interface IHospital
    {
        BaseDoctor CurrentDoctor { get; }
        string CurrentTreatment { get; }
        void AddDoctor(BaseDoctor doctor);
        void AddRangeDoctors(List<BaseDoctor> doctors);
        void Reception(Patient patient);
        Bill CreateBill();
        void ChecBill(Bill bill);
    }
}
