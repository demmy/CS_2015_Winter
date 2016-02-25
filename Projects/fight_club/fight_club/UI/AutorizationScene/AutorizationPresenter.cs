using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club.UI.AutorizationScene
{
    public class AutorizationPresenter
    {
        AutorizationUserControl view = null;

        public AutorizationPresenter(AutorizationUserControl view)
        {
            this.view = view;
        }
    }
}
