using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShopOwnerRepo : IRepository<ShopOwner, int>, IAuth<ShopOwner, string>
    {
        EhutBazardbEntities db;
        public ShopOwnerRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }



        public ShopOwner Get(int id)
        {
            return db.ShopOwners.FirstOrDefault(e => e.ShopO_Id == id);

        }

        public List<ShopOwner> GetAll()
        {
            return db.ShopOwners.ToList();
        }

        public void Insert(ShopOwner entity)
        {
            db.ShopOwners.Add(entity);
            db.SaveChanges();
        }

        public void Update(ShopOwner entity)
        {
            var s = db.ShopOwners.FirstOrDefault(en => en.ShopO_Id == entity.ShopO_Id);
            db.Entry(s).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var s = db.ShopOwners.FirstOrDefault(e => e.ShopO_Id == id);
            db.ShopOwners.Remove(s);
            db.SaveChanges();
        }

        public Token Authenticate(ShopOwner entity)
        {
            var u = db.ShopOwners.FirstOrDefault(en => en.ShopO_Username == entity.ShopO_Username && en.ShopO_Password == entity.ShopO_Password);
            Token t = null;
            if (u != null) //authenticated
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.User_Id = u.ShopO_Id;
                t.AccessToken = token;
                t.CreateDate = DateTime.Now;
                t.UserType = "ShopOwner";
                db.Tokens.Add(t);
                db.SaveChanges();

            }
            return t;
        }

        public bool IsAuthenticated(string token)
        {
            throw new NotImplementedException();
        }

        public bool Logout(string token)
        {
            throw new NotImplementedException();
        }
    }
}
