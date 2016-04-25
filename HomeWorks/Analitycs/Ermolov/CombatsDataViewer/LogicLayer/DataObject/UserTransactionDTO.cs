/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 4:22
 */
using System;

namespace LogicLayer.DataObject
{
    /// <summary>
    /// Description of UserTransactionDTO.
    /// </summary>
    public class UserTransactionDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal? Sum { get; set; }
    }
}
