using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace FightClub.UI
{
    public partial class SaveForm : Form
    {
        List<Save> _collection = null;
        string _fullpath = "";
        public SaveForm()
        {
            InitializeComponent();
        }
        private void UpdateGrid()
        {
            dataRecords.DataSource = null;
            dataRecords.DataSource = _collection;
        }

        private List<Save> Open() 
        {
            var users = new List<Save>();

            if (File.Exists(_fullpath))
            {
                foreach (var line in File.ReadAllLines(_fullpath))
                {
                    try
                    {
                        var columns = line.Split('\t');
                        users.Add(new Save() { Name = columns[0], Win = Convert.ToInt32(columns[1]) });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Loaded!");
            }
            else 
            {
                MessageBox.Show("File not found!");
            }
            users.Sort();
            return users;
        }
        private void SaveMethod(string fullpath)
        {
            if (File.Exists(fullpath))
            {
                TextWriter sw = new StreamWriter(fullpath, true, System.Text.Encoding.Default);
                for (int i = 0; i < dataRecords.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataRecords.Columns.Count; j++)
                    {
                        try
                        {
                            sw.Write(dataRecords.Rows[i].Cells[j].Value.ToString() + "\t");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    sw.WriteLine();
                }
                sw.Close();
                MessageBox.Show("Data Saved!");
            }
            else
            {
                TextWriter sw = new StreamWriter(fullpath, false, System.Text.Encoding.Default);
                for (int i = 0; i < dataRecords.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataRecords.Columns.Count; j++)
                    {
                        try
                        {
                            sw.Write(dataRecords.Rows[i].Cells[j].Value.ToString() + "\t");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
        static void Serialize()
        {
            List<Save> list = new List<Save>();
            list.Add(new Save() { Name = PlayerOptions.PlayerName, Win = PlayerOptions.PlayerCountWin });
            list.Add(new Save() { Name = PlayerOptions.BotName, Win = PlayerOptions.BotCountWin });
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, list);
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }


        static void Deserialize()
        {
            StringBuilder str = new StringBuilder();
            List<Save> list = null;

            FileStream fs = new FileStream("DataFile.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                list = (List<Save>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            foreach (var de in list)
            {
                str.AppendLine(de.Name + "\t" + de.Win);
            }
                MessageBox.Show( str.ToString(),"PVE");
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string filepath = path.Replace(@"\bin\Debug", "");
            string folder = @"\Resources\records.txt";
            _fullpath = filepath + folder;

            _collection = new List<Save> 
            {
                new Save(){ Name = PlayerOptions.PlayerName, Win = PlayerOptions.PlayerCountWin},
                new Save(){  Name = PlayerOptions.BotName, Win = PlayerOptions.BotCountWin}
            };
            UpdateGrid();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveMethod(_fullpath);
        }
        private void pveButton_Click(object sender, EventArgs e)
        {
            Serialize();
            Deserialize();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _collection = Open();
            UpdateGrid();
        }
    }
}
