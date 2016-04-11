using FightClubReports.Data.Entitys;
using FightClubReports.Data.Repository.Interfaces;
using FightClubReports.Repository;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Data.Repository
{
    public class StaticticsRepository : BaseRepository<Statistics>, IStatisticsRepository
    {
        public StaticticsRepository(Context db) : base(db)
        {

        }

    }
}
