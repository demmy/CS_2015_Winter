using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp
{
    

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(int hp, string name, PartOfBody part, PartOfBody block )
        {
            Hp = hp;
            Name = name;
            Part = part;
            Block = block;
        }
        public MyEventArgs(int hp, string name, PartOfBody block)
        {
            Hp = hp;
            Name = name;
            Block = block;
        }
        public MyEventArgs(int hp, string name)
        {
            Hp = hp;
            Name = name;
        }
        public int Hp { get; private set; }
        public string Name { get; private set; }
        public PartOfBody Part { get; private set; }
        public PartOfBody Block { get; private set; }
    }
}
