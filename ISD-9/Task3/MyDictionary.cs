using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<TKey,TValue>
    {
        ArrayList key = new ArrayList();
        ArrayList val = new ArrayList();
        int i = 0; 
        public int Count
        {
            get { return i;}
        }
        public void Add(TKey k, TValue v)
        {
            key.Add(k);
            val.Add(v);
            i++;
        }
        public TValue this[TKey index]
        {
            get { return (TValue)val[key.IndexOf(index)]; }
            set { val.Insert(key.IndexOf(index),value); }
        }
        public IEnumerable<TValue> GetDictionaryVal()
        {             
            for (int i = 0; i < val.Count; i++)
            {
                yield return (TValue)val[i];
            }
        }
        public IEnumerable<TKey> GetDictionaryKey()
        {
            for (int i = 0; i < val.Count; i++)
            {
                yield return (TKey)key[i];
            }
        }

        

        

    }
}
