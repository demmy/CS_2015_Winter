using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.Inerfaces
{
    public interface ITextInfo
    {
        int NumberOfFight { get ; }
        int NumberOfTie { get; }
        int NumberOfWin { get; }
        int NumberOfLoss { get; }
        void SetMessage();
        void WinnerName();
        string PatrtToString(PartOfBody part);
    }
}
