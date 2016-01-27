using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Interface
{
    public interface IPlayable
    {
        void Play();
        void Stop();
        void Pause();
    }

    public interface IRecodable
    {
        void Pause();
        void Record();
        void Stop();

    }
    public class Player : IPlayable, IRecodable
    {
        void IRecodable.Pause()
        {
            Console.WriteLine("Метод \"PAUSE\" при записи");
        }

        public void Record()
        {
            Console.WriteLine("Метод \"RECORD\" при записи");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Метод \"STOP\" при записи");
        }

        public void Play()
        {
            Console.WriteLine("Метод \"PLAY\" при проигрывании");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Метод \"PAUSE\" при проигрывании");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Метод \"STOP\" при проигрывании");
        }

        
    }
    
}
