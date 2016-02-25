using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] key = new TKey[10];
        TValue[] val = new TValue[10];
        private int i = 0;
        public TValue this[TKey index]
        {
            get
            {
                int j = 0;
                for (int f = 0; f < key.Length; f++)
                {
                    if (key[f].Equals(index))
                    {
                        j = f;
                    }
                }
                return val[j];
            }
        }
        public int Count
        {
            get { return i; }
        }
        public void Add(TKey newkey, TValue newval)
        {
            key[i] = newkey;
            val[i] = newval;
            i++;
        }
    }
}
