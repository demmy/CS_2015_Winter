using EF_Repository.Model;
using EF_Repository.Model.Interfaces;

namespace EF_Repository.Repository.Interfaces
{
    interface IPlayersRepository
    {
        void Add(Player entity);
        void Delete(Player entity);
        Player[] GetPlayers();
    }
}