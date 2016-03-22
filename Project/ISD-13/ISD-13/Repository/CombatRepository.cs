using ISD_13.Data;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    class CombatRepository : ICombatRepository
    {
        private Context db;
        public CombatRepository()
        {
            this.db = new Context();
        }        

        public IEnumerable<Combat> GetList()
        {
            return db.Combat;
        }

        public Combat Get(int id)
        {
            return db.Combat.Find(id);
        }

        public void Create(Combat combat)
        {
            db.Combat.Add(combat);
        }

        public void Update(Combat combat)
        {
            db.Entry(combat).State = EntityState.Modified;
        }

        public void Delate(int id)
        {
            Combat combat = db.Combat.Find(id);
            if (combat != null)
            {
                db.Combat.Remove(combat);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
