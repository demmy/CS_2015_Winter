/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 11.04.2016
 * Time: 20:37
 */
using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.EF;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Description of PlayerRepository.
    /// </summary>
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(Context db) : base(db) {}
    }
}
