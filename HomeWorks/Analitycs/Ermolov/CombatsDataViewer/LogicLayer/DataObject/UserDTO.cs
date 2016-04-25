/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 4:18
 */
using System;
using System.ComponentModel;

namespace LogicLayer.DataObject
{
    /// <summary>
    /// Description of UserDTO.
    /// </summary>
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        [DisplayName("Validated")]
        public bool IsEMailValidated { get; set; }
        [DisplayName("Character")]
        public string CharacterName { get; set; }
        [DisplayName("Date")]
        public DateTime RegistrationDate { get; set; }
    }
}
