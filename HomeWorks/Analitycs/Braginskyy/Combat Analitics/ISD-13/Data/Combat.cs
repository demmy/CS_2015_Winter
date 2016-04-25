using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Combat : AbstractPlayer
    {        
        public bool CombatTypePVP { get; set; }
        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }
        public Player Winner { get; set; }
        public int Experience { get; set; }       
        public virtual List<HitLog> CombatLog { get; set; }        
        public virtual List<Player> Players { get; set; }
        public Combat()
        {
            Players = new List<Player>();
        }
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
