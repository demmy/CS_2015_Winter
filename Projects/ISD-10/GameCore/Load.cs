using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameCore
{
    public class Loader : ILoader
    {        
        string saveFile = @".\save.dat";
        List<Character> tableSave = new List<Character>();        
        public List<Character> LoadPlayer(string playerName)
        {            
            Read();
            int k = 0;
            for (int i = 0; i < tableSave.Count; i += 2)
            {
                if (tableSave[i].Name == playerName)
                {
                    tableSave[0] = tableSave[i];
                    tableSave[1] = tableSave[i + 1];
                    tableSave.RemoveRange(2, tableSave.Count - 2);
                    k = 1;
                }
            }
            if (k == 1)
            {
                return tableSave;
            }
            else
            {
                tableSave.Clear();
                return tableSave;
            }
        }
        private void Read()
        {
            if (File.Exists(saveFile))
            {
                tableSave.Clear();
                using (BinaryReader reader = new BinaryReader(File.Open(saveFile, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        tableSave.Add(new Character()
                        {
                            Name = reader.ReadString(),
                            MaxHp = reader.ReadInt32(),
                            Hp = reader.ReadInt32(),
                            Strength = reader.ReadInt32(),
                            Armor = reader.ReadInt32(),
                            Bonus = reader.ReadInt32()
                        });
                    }
                }
            }           
        }
    }
}
