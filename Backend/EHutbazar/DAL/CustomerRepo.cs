using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CustomerRepo : IRepository<Customer, int>
    {
        EhutBazardbEntities db;
        public CustomerRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }
        public void Delete(int id)
        {
            var s = db.Customers.FirstOrDefault(e => e.Customer_Id == id);
            db.Customers.Remove(s);
            db.SaveChanges();
        }

        public Customer Get(int id)
        {
            return db.Customers.FirstOrDefault(e => e.Customer_Id == id);
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public void Insert(Customer entity)
        {
            db.Customers.Add(entity);
            db.SaveChanges();
        }

        public void Update(Customer entity)
        {
            var s = db.Customers.FirstOrDefault(en => en.Customer_Id == entity.Customer_Id);
            db.Entry(s).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}
