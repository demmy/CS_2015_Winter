using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubStatistics;

namespace FightClubStatistics.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAllWithValidEmail();
        IEnumerable<User> GetAllWithoutValidEmail();
    }
}
