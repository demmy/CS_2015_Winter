using System;
using EF_Repository.Data;
using EF_Repository.Data.Interfaces;

namespace EfWinform.Class.Services
{
    internal abstract class Service
    {
        protected IUnitOfWork UnitOfWork;

        protected Service()
        {
            UnitOfWork = new UnitOfWork();
        }

        public abstract Array Get();
        public abstract void DeleteById(int id);

        public void Save()
        {
            UnitOfWork.Commit();
        }
    }
}
   

   



