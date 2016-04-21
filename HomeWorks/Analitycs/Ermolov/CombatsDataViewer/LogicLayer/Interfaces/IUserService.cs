﻿/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 4:51
 */
using System;
using System.Collections.Generic;
using LogicLayer.DataObject;

namespace LogicLayer.Interfaces
{
    /// <summary>
    /// Description of IUserService.
    /// </summary>
    public interface IUserService
    {
        List<UserDTO> GetAllUsers();
        UserDTO GetUser(int userId);
        void AddUser(UserDTO user);
        void EditUser(UserDTO user);
        List<UserDTO> GetUsersBySearchString(string word);
        List<UserDTO> GetLastTenUsers();
        List<UserDTO> GetUsersWithValidEMail();
        List<UserDTO> GetTopTenDonators();
        PlayerDTO GetCharacterStatistic(int userId);
    }
}
