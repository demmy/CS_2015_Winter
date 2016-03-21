/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.02.2016
 * Time: 9:58
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Combats
{
    /// <summary>
    /// Description of MainUserControl.
    /// </summary>
    public partial class MainUserControl : BaseUserConrol
    {
        public MainUserControl()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            ShowRecordsInTable();
        }

        void StartGameClick(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(InputPlayerName.Text))
            {
                InputPlayerName.BackColor = Color.IndianRed;
                return;
            }
            else
            {
                InputPlayerName.BackColor = Color.Empty;
            }
            ProgramData.PlayerName = InputPlayerName.Text;
            SwitchScene(Scene.Battle);
        }
        
        void ShowRecordsInTable()
        {
            if (CheckFileExist(ProgramData.RatingFilePath))
            {
                ProgramData.Rating = new Dictionary<string, int>();
                var file = File.ReadAllLines(ProgramData.RatingFilePath, Encoding.UTF8);
                for (int i = 0; i < file.Length; i++)
                {
                    string[] temp = file[i].Split(';');
                    ProgramData.Rating.Add(temp[0], Convert.ToInt16(temp[1]));
                }
                int n = 0;
                foreach (var line in ProgramData.Rating.OrderByDescending(kvp => kvp.Value))
                {
                    n++;
                    TopPlayesTable.Rows.Add(n, line.Key, line.Value);
                }
                TopPlayesTable.AllowUserToResizeRows = false;
                TopPlayesTable.AllowUserToAddRows = false;
                TopPlayesTable.RowCount = 10;
            }
        }
        
        bool CheckFileExist(string file)
        {
            if (!File.Exists(file))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
