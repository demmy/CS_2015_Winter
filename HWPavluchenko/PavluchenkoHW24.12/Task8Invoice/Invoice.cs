using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8Invoice
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article = "ASUS";
        int quantity = 2;
        public Invoice(int acc, string cust, string prov)
        {
            account = acc;
            customer = cust;
            provider = prov;

        }
        public void Price()
        {
            double model = 0;

            switch (article)
            {
                case "Lenovo":
                    model = 300;
                    break;
                case "ASUS":
                    model = 400;
                    break;
                case "SAMSUNG":
                    model = 500;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Prise = {0}$\nPrice with VAT = {1}$", (model * quantity), (model * quantity) * 0.2
                                                                   + (model * quantity));
            Console.ReadLine();
        }
      
    }
}
