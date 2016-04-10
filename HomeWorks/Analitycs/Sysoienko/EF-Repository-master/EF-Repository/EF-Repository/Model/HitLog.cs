using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Repository.Model
{
    class HitLog
    {
        [Key]
        public int CombatId { get; set; }
        public string FirstPlayerLogin { get; set; }
        public string SecondPlayerLogin { get; set; }
        public int FirstPlayerHitValue { get; set; }
        public int SecondPlayerHitValue { get; set; }
        [Required]
        public virtual Combat Combat { get; set; }
    }
}
