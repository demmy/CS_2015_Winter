/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:44
 */
using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    /// <summary>
    /// Description of User.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public bool IsEMailValid { get; set; }
        public virtual Player Character { get; set; }
        public virtual ICollection<UserTransaction> UserTransactions { get; set; }
    }
}
