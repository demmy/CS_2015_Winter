/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 4:26
 */
using System;

namespace LogicLayer.DataObject
{
    /// <summary>
    /// Description of PlayerDTO.
    /// </summary>
    public class PlayerDTO
    {
        public string CharacterName { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draws { get; set; }
    }
}
