using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class MyClass
    {       
        public IEnumerable<int> GetMass(int [] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    yield return mass[i]; 
                }                 
            }
            
        }
    }
}
