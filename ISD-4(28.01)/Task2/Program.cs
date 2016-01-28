using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Play();
            p.Record();
            p.Pause();
            ((IPlayable)p).Stop();
            ((IRecordable)p).Stop();
            Console.ReadLine();
        }
    }
}
