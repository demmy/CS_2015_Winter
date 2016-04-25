using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject
{
    public interface IPatient : IHuman
    {
        Bill PatientBill { get; set; }
        Complaint PatientComplaint { get; set; }
        void PayBill();
    }
}
