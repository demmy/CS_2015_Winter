using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public delegate int Exampl();
    public delegate double Anonymus(Exampl[] d);
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Exampl[] d = new Exampl[100];
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = new Exampl(Ran);                
            }
            Anonymus anonimousDelegat;
            anonimousDelegat = (mass) =>
            {                
                for (int i = 0; i < mass.Length; i++)
                {
                    sum = sum + (double)mass[i]()/mass.Length;                    
                }
                return sum;                
            };
            anonimousDelegat(d);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static int Ran()
        {
            Random r = new Random();
            return r.Next(1, 100);
        }
    }
}
