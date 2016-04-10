using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Repository.Model
{
    class Transcation
    {
        [Key]
        public int TransactId { get; set; }
        public int Sum { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public int PlayerId { get; set; }
        [Required]
        public virtual Player Player { get; set; }
    }
}
