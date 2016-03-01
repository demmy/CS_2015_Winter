using GameCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GameCore
{
    public class Saver : ISaver
    {
        string saveFile = @".\save.dat";
        List<Character> tableSave = new List<Character>();
        public void Save(IPlayer player, IBot bot)
        {
            if (File.Exists(saveFile))
            {
                Read();
                File.Delete(saveFile);
                int k = 0;
                for (int i = 0; i < tableSave.Count; i += 2)
                {
                    if (tableSave[i].Name == player.Name)
                    {
                        tableSave[i].Name = player.Name;
                        tableSave[i].MaxHp = player.MaxHp;
                        tableSave[i].Hp = player.Hp;
                        tableSave[i].Strength = player.Strength;
                        tableSave[i].Armor = player.Armor;
                        tableSave[i].Bonus = player.Bonus;
                        tableSave[i + 1].Name = bot.Name;
                        tableSave[i + 1].MaxHp = bot.MaxHp;
                        tableSave[i + 1].Hp = bot.Hp;
                        tableSave[i + 1].Strength = bot.Strength;
                        tableSave[i + 1].Armor = bot.Armor;
                        tableSave[i + 1].Bonus = bot.Bonus;
                        k = 1;
                    }
                }
                if (k == 0)
                {
                    tableSave.Add(new Character()
                    {
                        Name = player.Name,
                        MaxHp = player.MaxHp,
                        Hp = player.Hp,
                        Strength = player.Strength,
                        Armor = player.Armor,
                        Bonus = player.Bonus
                    });
                    tableSave.Add(new Character()
                    {
                        Name = bot.Name,
                        MaxHp = bot.MaxHp,
                        Hp = bot.Hp,
                        Strength = bot.Strength,
                        Armor = bot.Armor,
                        Bonus = bot.Bonus
                    });
                }
                Write();
            }
            else
            {
                tableSave.Add(new Character()
                {
                    Name = player.Name,
                    MaxHp = player.MaxHp,
                    Hp = player.Hp,
                    Strength = player.Strength,
                    Armor = player.Armor,
                    Bonus = player.Bonus
                });
                tableSave.Add(new Character()
                {
                    Name = bot.Name,
                    MaxHp = bot.MaxHp,
                    Hp = bot.Hp,
                    Strength = bot.Strength,
                    Armor = bot.Armor,
                    Bonus = bot.Bonus
                });
                Write();
            }
        }        
        private void Read()
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
        private void Write()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(saveFile, FileMode.OpenOrCreate)))
            {
                foreach (Character c in tableSave)
                {
                    writer.Write(c.Name);
                    writer.Write(c.MaxHp);
                    writer.Write(c.Hp);
                    writer.Write(c.Strength);
                    writer.Write(c.Armor);
                    writer.Write(c.Bonus);
                }
            }
        }
    }
}
