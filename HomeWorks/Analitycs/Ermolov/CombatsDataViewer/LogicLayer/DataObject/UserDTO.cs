/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 4:18
 */
using System;

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
        public bool IsEMailValidated { get; set; }
        public string CharacterName { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
