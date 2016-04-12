/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 15:58
 */
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataLayer.EF;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Description of UserRepository.
    /// </summary>
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(Context db) : base(db) {}
    }
}
