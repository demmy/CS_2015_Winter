using System;
using System.Windows.Forms;

namespace FightClub.UI
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }
        private void InformationForm_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string filepath = path.Replace(@"\bin\Debug", "");
            string folder = @"\Resources\FC.rtf";
            string fullpath = filepath + folder;
            informationTextBox.LoadFile(fullpath);
        }
    }
}
