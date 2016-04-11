using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Repository.Model
{
    class Combat
    {
        public Combat()
        {
            Players = new HashSet<Player>();
            Pves = new List<Pve>();
            Pvps = new List<Pvp>();
        }
        public int CombatId { get; set; }
        public string Winner { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public virtual HitLog HitLog { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Pve> Pves { get; set; }
        public virtual ICollection<Pvp> Pvps { get; set; }
    }
}
