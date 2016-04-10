using EF_Repository.Model;

namespace EF_Repository.Repository.Interfaces
{
     interface IHitLogsRepository
    {
        void Add(HitLog entity);
        void Delete(HitLog entity);
        HitLog[] GetHitLogs(); 
    }
}