using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class AffiliatorRepo : IRepository<Affiliator, int>
    {
        EhutBazardbEntities db;
        public AffiliatorRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            var s = db.Affiliators.FirstOrDefault(e => e.Affiliate_Id == id);
            db.Affiliators.Remove(s);
            db.SaveChanges();
        }

        public Affiliator Get(int id)
        {
            return db.Affiliators.FirstOrDefault(e => e.Affiliate_Id == id);
        }

        public List<Affiliator> GetAll()
        {
            return db.Affiliators.ToList();
        }

        public void Insert(Affiliator entity)
        {
            db.Affiliators.Add(entity);
            db.SaveChanges();
        }

        public void Update(Affiliator entity)
        {
            var s = db.Affiliators.FirstOrDefault(en => en.Affiliate_Id == entity.Affiliate_Id);
            db.Entry(s).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}
