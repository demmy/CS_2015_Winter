using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Bill 
    {
        bool status;
        string shortfall;

        public Bill(DateTime date, string clientFullName, string reason, decimal sum)
        {
            Date = date;
            ClientFullName = clientFullName;
            Case = reason;
            Sum = sum;
        }
        
        public DateTime Date { get; private set; }

        public string ClientFullName { get; private set; }

        public string Case { get; private set; }

        public decimal Sum { get; private set; }

        public string Status
        {
            get
            {
                if (status == true)
                {
                    return "Paid";
                }
                else 
                {
                    StringBuilder s = new StringBuilder();
                    s.AppendFormat("Not paid.{0}", shortfall);
                    return s.ToString();
                }
            }
            set
            {
                if (value == "payment")
                {
                    status = true;
                }
                else
                {
                    shortfall = value;
                }
            }
        }
        
    }
}
