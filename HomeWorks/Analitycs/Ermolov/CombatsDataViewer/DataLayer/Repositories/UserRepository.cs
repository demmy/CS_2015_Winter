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

        public int GetLastUsedUserId()
        {
            if (db.Users.Where(u => u.Id != 0).Count() > 0)
                return db.Users.OrderByDescending(u => u.Id).FirstOrDefault().Id;
            else
                return 0;
        }

        public User GetUserByLogin(string login)
        {
                return db.Users.Where(u => u.Login == login).FirstOrDefault();
        }
    }
}
