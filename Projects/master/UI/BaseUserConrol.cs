/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.02.2016
 * Time: 10:08
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Combats
{
    /// <summary>
    /// Description of BaseUserConrol.
    /// </summary>
    public partial class BaseUserConrol : UserControl
    {
        public void SwitchScene(Scene targetScene)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene);
        }
        

    }
}
