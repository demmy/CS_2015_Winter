/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 2:27
 */
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataLayer.EF;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Description of BattleLogRepository.
    /// </summary>
    public class BattleLogRepository : BaseRepository<BattleLog>, IBattleLogRepository
    {
        public BattleLogRepository(Context db) : base(db) {}
    }
}
