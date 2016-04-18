using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Repository.Model
{
 public  class HitLog
    {
        [Key]
        public int CombatId { get; set; }
        public string PlayerLogin { get; set; }
        public string EnemyLogin { get; set; }
        public int PlayerHitValue { get; set; }
        public int EnemyHitValue { get; set; }
        [Required]
        public virtual Combat Combat { get; set; }
    }
}
