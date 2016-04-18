using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public static class Extensions
    {
        public static void Mark(this System.Windows.Forms.Button button)
        {
            button.BackColor = System.Drawing.Color.Gray;
        }
        public static void UnMark(this System.Windows.Forms.Button button)
        {
            button.BackColor = System.Drawing.Color.White;
        }
        public static void ChangeMark(this System.Windows.Forms.Button button)
        {
            if (button.BackColor == System.Drawing.Color.Gray)
            {
                button.BackColor = System.Drawing.Color.White;
            }
            else
            {
                button.BackColor = System.Drawing.Color.Gray;
            }
        }
    }
}
