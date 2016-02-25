using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class MyExtentions
    {
        public static string MySubstring(this string s, int i, int j)
        {
            StringBuilder substring = new StringBuilder();
            for (int f = i; f < i + j; f++)
            {
                substring.Append(s[f]);
            }
            return substring.ToString();
        }
        public static int MyIndexOf(this string s, string substring)
        {
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == substring[j])
                {
                    j++;
                    if (j == substring.Length)
                    {
                        return i - j + 1;
                    }
                    if (s[i + 1] != substring[j])
                    {
                        j = 0;

                    }
                }
            }
            return -1;
        }
        public static string MyReplace(this string s, string oldValue, string newValue)
        {
            StringBuilder newString = new StringBuilder();
            int j = 0;
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                newString.Append(s[i]);
                k++;
                if (s[i] == oldValue[j])
                {
                    j++;
                    if (j == oldValue.Length)
                    {
                        newString.Remove(k-oldValue.Length, oldValue.Length);
                        newString.Append(newValue);
                        k = newString.Length;
                        j = 0;                        
                    }
                    if (s[i + 1] != oldValue[j])
                    {
                        j = 0;
                    }
                }                
            }
            return newString.ToString();
        }
    }
}
