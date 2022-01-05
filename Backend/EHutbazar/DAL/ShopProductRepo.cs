using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ShopProductRepo : IRepository<Shop_Product, int>
    {
        EhutBazardbEntities db;
        public ShopProductRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }
       public void Delete(int id)
        {
            var s = db.Shop_Product.FirstOrDefault(e => e.Product_Id == id);
            db.Shop_Product.Remove(s);
            db.SaveChanges();
        }

        public Shop_Product Get(int id)
        {
            return db.Shop_Product.FirstOrDefault(e => e.Product_Id == id);
        }

        public List<Shop_Product> GetAll()
        {
            return db.Shop_Product.ToList();
        }

        public void Insert(Shop_Product entity)
        {
            db.Shop_Product.Add(entity);
            db.SaveChanges();
        }

        public void Update(Shop_Product entity)
        {
            var s = db.Shop_Product.FirstOrDefault(en => en.Product_Id == entity.Product_Id);
            db.Entry(s).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}
