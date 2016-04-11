using EF_Repository.Model;

namespace EF_Repository.Repository.Interfaces
{
    interface IPvpsRepository
    {
        void Add(Pvp entity);
        void Delete(Pvp entity);
        Pvp[] GetPvps();
    }
}