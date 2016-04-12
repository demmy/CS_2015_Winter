/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:46
 */
using System;

namespace DataLayer.Entities
{
    /// <summary>
    /// Description of UserTransaction.
    /// </summary>
    public class UserTransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }
        public string Description { get; set; }
        public decimal Sum { get; set; }
    }
}
