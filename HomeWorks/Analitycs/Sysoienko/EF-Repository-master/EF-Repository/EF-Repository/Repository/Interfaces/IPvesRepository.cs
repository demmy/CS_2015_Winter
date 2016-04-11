using EF_Repository.Model;

namespace EF_Repository.Repository.Interfaces
{
    interface IPvesRepository
    {
        void Add(Pve entity);
        void Delete(Pve entity);
        Pve[] GetPves();
    }
}