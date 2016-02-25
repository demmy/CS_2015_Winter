using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyList<T>
    {
        T[] mass = new T[10];
        private int i = 0;
        public T this[int index]
        {
            get { return mass[index]; }
            set { mass[index] = value; }
        }
        public int Count
        {
            get { return i; }
        }
        public T Add(T newElement)
        {
            mass[i] = newElement;
            i++;
            return mass[i];
        }
    }
}
