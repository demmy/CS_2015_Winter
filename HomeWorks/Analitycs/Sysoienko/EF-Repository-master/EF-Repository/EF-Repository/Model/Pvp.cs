using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Repository.Model
{
    class Pvp
    {
        [Key]
        public int PvpId { get; set; }
        public int CombatId { get; set; }
        public Combat Combat;
        public Player First { get; set; }
        public Player Second { get; set; }
    }
}
