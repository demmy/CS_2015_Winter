using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Repository.Model.Interfaces;
using Microsoft.Build.Framework;

namespace EF_Repository.Model
{
     class Player:IPlayer
    {
        public Player()
        {
            Transactions = new HashSet<Transcation>();
        }
        public int PlayerId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsValidEmail { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public Nullable<int> CombatId { get; set; }
        [Required]
        public virtual Combat Combat { get; set; }
        public virtual ICollection<Transcation> Transactions { get; set; }
    }
}
