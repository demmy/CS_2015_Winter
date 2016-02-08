using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class CarCollection<T>
    {
        int i = 0;
        List<T> Model = new List<T>();
        List<T> Year = new List<T>();
        public int Count
        {
            get { return i; }
        }
        public string this[int index]
        {
            get 
            {
                return Model[index].ToString()+"    "+Year[index].ToString();
            } 
        }
        public void Add(T model, T year)
        {
            Model.Add(model);
            Year.Add(year);
            i++;
        }        
    }
}
