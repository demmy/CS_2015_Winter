using System;
using System.Linq;
using EF_Repository.Data;
using EF_Repository.Model;
using EF_Repository.Model.Interfaces;
using EF_Repository.Repository.Interfaces;

namespace EF_Repository.Repository
{
    class PlayersRepository: IPlayersRepository,IDisposable
    {
        private readonly EfContext _entity;

        public PlayersRepository(EfContext entity)
        {
            _entity = entity;
        }

        public void Add(Player entity)
        {
            _entity.Players.Add(entity);
        }

        public void Delete(Player entity)
        {
            _entity.Players.Remove(entity);
        }
        public Player[] GetPlayers()
        {
            return _entity.Players.ToArray();
        }
        public void SaveChanges()
        {
            _entity.SaveChanges();
        }

        public void Dispose()
        {
            if (_entity != null)
            {
                _entity.Dispose();
            }
        }
    }
}
