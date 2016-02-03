using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Notebook
    {
        string model;
        string manufacturer;
        float price;
        public Notebook(string model, string manufacturer, float price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public void PrintInfo()
        {
            Console.WriteLine("model : {0}\nmanufacturer : {1}\nprice : {2}", model, manufacturer, price);
        }
    }
}
