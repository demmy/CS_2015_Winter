using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Interface
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Player first = new Player();
            IPlayable pl = (IPlayable)first;
            IRecodable rec = (IRecodable)first;

            first.Play();
            pl.Pause();
            pl.Stop();

            Console.ReadLine();

            first.Record();
            rec.Pause();
            rec.Stop();

        }
    }
}
