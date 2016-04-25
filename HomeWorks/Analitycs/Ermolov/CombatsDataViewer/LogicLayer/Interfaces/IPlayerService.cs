/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 5:03
 */
using System;
using System.Collections.Generic;
using LogicLayer.DataObject;

namespace LogicLayer.Interfaces
{
    /// <summary>
    /// Description of IPlayerService.
    /// </summary>
    public interface IPlayerService
    {
        IEnumerable<PlayerDTO> GetAllPlayers();
        PlayerDTO GetPlayer(int userId);
    }
}
