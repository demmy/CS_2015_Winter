using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class ArrayList
    {
        int i = 0;       
        int k = 0;        
        object[][] arr = new object[100][];        
        public ArrayList()
        {
            arr[i] = new object[4];
        }
        public object this[int index]
        {
            get { return arr[i][index]; }
            set { arr[i][index] = value; }
        }
        public int Count
        {
            get { return k; }            
        }
        public int Capacity
        {
            get { return arr[i].Length; }
            set { k = value/2; ArrayCreate(); }
        }
        public void Add(object item)
        {
            if (k >= arr[i].Length)
            {                
                ArrayCreate();
                Add(item);
            }
            else 
            {
                arr[i][k] = item;
                k++;
            } 
        }
        public object[] ArrayCreate()
        {
            i++;
            arr[i] = new object[k*2];
            for (int j = 0; j < arr[i - 1].Length; j++)
            {
                arr[i][j] = arr[i - 1][j]; 
            }
                return arr[i];
        }
    }
}
