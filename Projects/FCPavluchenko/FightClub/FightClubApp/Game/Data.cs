using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubApp.UI.Login;
using FightClubApp.FightersClasses;
using FightClubApp.Game.Inerfaces;

namespace FightClubApp.Game
{
    [Serializable]
    public class Data : IData, IComparable<Data>
    {
        public string Name { get; set; }
        public int NumberOfFight { get; set; }
        public int NumberOfWin { get; set; }
        public int NumberOfTie { get; set; }
        public int NumberOfLoss { get; set; }

        public Data( string name, int fight, int win, int tie, int losse) // запилить напрямую
        {
            Name = name;
            NumberOfFight = fight;
            NumberOfWin = win;
            NumberOfTie = tie;
            NumberOfLoss = losse;
        }
        public Data()
        {

        }

        public int CompareTo(Data obj)
        {
            if (this.NumberOfWin > obj.NumberOfWin)
            {
                return -1;
            }
            else if (this.NumberOfWin == obj.NumberOfWin)
            {
                if (NumberOfTie > obj.NumberOfTie)
                {
                    return -1;
                }
                else if (NumberOfTie < obj.NumberOfTie)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 1;
            }
            
        }
    }
}
