using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class PlayersRecordInfo
    {
        public string Name { get; set; }
        public int Exp { get; set; }

        public PlayersRecordInfo(Player player)
        {
            Name = player.Name;
            Exp = player.Exp;
        }
    }
}
