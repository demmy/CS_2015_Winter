using EF_Repository.Model;

namespace EF_Repository.Repository.Interfaces
{
     interface ICombatsRepository
    {
        void Add(Combat entity);
        void Delete(Combat entity);
         Combat[] GetCombats();
    }
}