using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfWinform.Interface
{
    interface ICombatForm
    {
        event EventHandler ShowCombatGrid;
        object CombatGrid { set; }
    }
}
