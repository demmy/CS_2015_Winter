using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club.UI.MenuScene
{
    public class MenuPresenter
    {
        MenuUserControl view;
        public MenuPresenter(MenuUserControl view)
        {
            this.view = view;
        }
    }
}
