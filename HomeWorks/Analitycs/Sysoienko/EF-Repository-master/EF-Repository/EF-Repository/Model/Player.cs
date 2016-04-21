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
    public class Player:IPlayer
    {
        public Player()
        {
            Transactions = new List<Transaction>();
           // Combats = new List<Combat>();
        }
        public int PlayerId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsValidEmail { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public int? CombatId { get; set; }
        public Combat Combat { get; set; }
       // public virtual List<Combat> Combats { get; set; } 
        public virtual  List<Transaction> Transactions { get; set; }
    }
}
