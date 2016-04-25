using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Patient : Person, IPatient
    {
        string complaint;
        bool complaintStatus;

        public Patient(string fullName, string complaint) : base ( fullName )
        {
            this.complaint = complaint;
            complaintStatus = true;
        }

        public string Complaint
        {
            get
            {
                if (complaintStatus == true)
                {
                    return complaint;
                }
                else
                {
                    return "No complaints";
                }
            }
            set
            {
                if (value == "Actual treatment")
                {
                    complaintStatus = false;
                }
            }
        }
        
    }
}
