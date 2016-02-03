using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("StopPLAY");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("StopRECORD");
        }
    }
}
