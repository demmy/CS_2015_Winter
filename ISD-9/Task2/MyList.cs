using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyList<T> : IEnumerable<T>
    {
        ArrayList arr = new ArrayList();
        public int i = 0;
        public T this[int index]
        {
            get { return (T)arr[index]; }
            set { arr.Insert(index, value); }
        }
        public int Count
        {
            get { return i; }
        }
        public void Add(T newElement)
        {
            arr.Add(newElement);
            i++;
        }
        public IEnumerable<T> GetList()
        {
            for (int j = 0; j < i; j++)
            {
                yield return (T)arr[j];
            }
        }
        public object Current
        {
            get { return arr[i]; }
        }

        public bool MoveNext()
        {
            if (i < arr.Count - 1)
            {
                i++;
                return true;
            }
            else { Reset(); return false; }
        }
        public void Reset()
        {
            i = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T obj in arr)
                yield return obj;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
}
