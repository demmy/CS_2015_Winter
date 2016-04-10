using EF_Repository.Model;

namespace EF_Repository.Repository.Interfaces
{
     interface ITransactionsRepository
    {
        void Add(Transcation entity);
        void Delete(Transcation entity);
        Transcation[] GetTranscations();
    }
}