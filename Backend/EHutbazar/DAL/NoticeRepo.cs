using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class NoticeRepo : IRepository<Notice, int>
    {
        EhutBazardbEntities db;
        public NoticeRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            var s = db.Notices.FirstOrDefault(e => e.Notice_Id == id);
            db.Notices.Remove(s);
            db.SaveChanges();
        }

        public Notice Get(int id)
        {
            return db.Notices.FirstOrDefault(e => e.Notice_Id == id);
        }

        public List<Notice> GetAll()
        {
            return db.Notices.ToList();
        }

        public void Insert(Notice entity)
        {
            db.Notices.Add(entity);
            db.SaveChanges();
        }

        public void Update(Notice entity)
        {
            var s = db.Notices.FirstOrDefault(en => en.Notice_Id == entity.Notice_Id);
            db.Entry(s).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}
