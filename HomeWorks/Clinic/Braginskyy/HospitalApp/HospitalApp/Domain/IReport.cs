using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Domain
{
    public interface IReport
    {
        int Id { get; set; }
        DateTime Date { get; set; }
        bool Status { get; set; }
    }
}
