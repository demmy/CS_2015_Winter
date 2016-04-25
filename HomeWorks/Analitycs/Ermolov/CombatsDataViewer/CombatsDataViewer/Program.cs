/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 08.04.2016
 * Time: 9:32
 */
using System;
using System.Windows.Forms;

namespace CombatsDataViewer
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
    }
}
