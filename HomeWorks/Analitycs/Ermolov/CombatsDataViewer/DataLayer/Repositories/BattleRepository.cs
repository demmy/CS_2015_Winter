/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 11.04.2016
 * Time: 20:43
 */
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataLayer.EF;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Description of BattleRepository.
    /// </summary>
    public class BattleRepository : BaseRepository<Battle>, IBattleRepository
    {
        public BattleRepository(Context db) : base(db) {}
    }
}
