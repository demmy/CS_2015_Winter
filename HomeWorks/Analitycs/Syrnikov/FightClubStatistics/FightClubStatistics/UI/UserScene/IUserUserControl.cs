using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics.UI.UserScene
{
    public interface IUserUserControl : IUserControl
    {
        void DrawUsersTable(List<User> userList);
        void ChangeCounter(int count);
    }
}
