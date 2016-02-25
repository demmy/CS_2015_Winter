using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club.UI.PlayerCreationScene
{
    public class PlayerCreationPresenter
    {
        PlayerCreationUserControl view;
        public PlayerCreationPresenter(PlayerCreationUserControl view)
        {
            this.view = view;
        }
    }
}
