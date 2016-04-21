using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Repository.Model
{
 public  class Pve
    {
        [Key]
        public int PveId { get; set; }
        public int CombatId { get; set; }
        public Combat Combat { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
