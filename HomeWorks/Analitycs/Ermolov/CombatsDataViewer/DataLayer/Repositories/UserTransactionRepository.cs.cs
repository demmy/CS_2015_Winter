/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 11.04.2016
 * Time: 17:15
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
    /// Description of UserTransaction.
    /// </summary>
    public class UserTransactionRepository : BaseRepository<UserTransaction>, IUserTransactionRepository
    {
        public UserTransactionRepository(Context db) : base(db) {}
    }
}
