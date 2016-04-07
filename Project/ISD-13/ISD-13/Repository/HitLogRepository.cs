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
    class HitLogRepository: IHitLogRepository
    {
        private Context db;
        public HitLogRepository()
        {
            this.db = new Context();
        }        

        public IEnumerable<HitLog> GetList()
        {
            return db.HitLog;
        }

        public HitLog Get(int id)
        {
            return db.HitLog.Find(id);
        }

        public void Create(HitLog hitLog)
        {
            db.HitLog.Add(hitLog);
        }

        public void Update(HitLog hitLog)
        {
            db.Entry(hitLog).State = EntityState.Modified;
        }

        public void Delate(int id)
        {
            HitLog hitLog = db.HitLog.Find(id);
            if (hitLog != null)
            {
                db.HitLog.Remove(hitLog);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
