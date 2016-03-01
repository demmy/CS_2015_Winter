using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    [Serializable]
    public class PlayerRepository : IPlayerRepository
    {
        List<Player> elements = null;
        public PlayerRepository()
        {
            elements = PlayersSaver.Load();
        }

        public void Add(Player player)
        {
            if (IsExist(player.Name))
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i].Name == player.Name)
                    {
                        elements[i] = player;
                    }
                }
            }
            else
            {
                elements.Add(player);
            }
        }

        public Player Get(string name)
        {
            Player player = null;
            if (IsExist(name))
            {
                foreach (var item in elements)
                {
                    if (item.Name == name)
                    {
                        player = item;
                    }
                }
            }
            return player;
        }

        public List<Player> GetAll()
        {
            return elements;
        }

        public bool IsExist(string name)
        {
            bool exist = false;
            foreach (var item in elements)
            {
                if (item.Name == name)
                {
                    exist = true;
                }
            }
            return exist;
        }

        public void Save()
        {
            PlayersSaver.Save(elements);
        }

        public List<PlayersRecordInfo> GetAllRecords()
        {
            List<PlayersRecordInfo> outputlist = new List<PlayersRecordInfo>();
            foreach (var item in elements)
            {
                outputlist.Add(new PlayersRecordInfo(item));
            }
            return outputlist;
        }
    }
}
