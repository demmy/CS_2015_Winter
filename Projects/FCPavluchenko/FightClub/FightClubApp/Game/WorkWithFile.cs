using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using FightClubApp.Game.Inerfaces;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace FightClubApp.Game
{
    public class WorkWithFile
    {
        IData data = null;
        string dataFile = @".\Data.dat";
        public WorkWithFile(IData data)
        {
            this.data = data;
        }
        public WorkWithFile()
        {
        }

        Data [] table = new  Data [20];

        public void AddData()
        {
            table = ReadFile();
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i].Name != data.Name)
                {
                        if (table[i].Name == "пусто")
                        {
                            table[i].Name = data.Name;
                            table[i].NumberOfFight += data.NumberOfFight;
                            table[i].NumberOfWin += data.NumberOfWin;
                            table[i].NumberOfTie += data.NumberOfTie;
                            table[i].NumberOfLoss += data.NumberOfLoss;
                            break;
                        }    
                }
                else
                { 
                    // method
                    table[i].NumberOfFight += data.NumberOfFight;
                    table[i].NumberOfWin += data.NumberOfWin;
                    table[i].NumberOfTie += data.NumberOfTie;
                    table[i].NumberOfLoss += data.NumberOfLoss;
                    break;
                }
            }
            Array.Sort(table);
            SaveFile();
        }

        BinaryFormatter formatter = new BinaryFormatter();

        public void SaveFile()
        {
            using (FileStream fs = new FileStream(dataFile, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, table);
            }
        }

        public Data [] ReadFile()
        {
            if (File.Exists(dataFile))
            {
                using (FileStream fs = new FileStream(dataFile, FileMode.Open))
                {
                    return (Data [])formatter.Deserialize(fs);
                }
            }
            else
            {
                for (int i = 0; i < table.Length; i++)
                {
                    table[i] = (new Data("пусто", 0, 0, 0, 0));
                }
                return table;
            }

        }






        //XmlSerializer formatter = new XmlSerializer(typeof(Data));
        //using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
        //{

        //}




    }
}
