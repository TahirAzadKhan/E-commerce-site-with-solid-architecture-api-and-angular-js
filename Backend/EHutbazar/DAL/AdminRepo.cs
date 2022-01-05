using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRepo : IRepository<Admin, int>,IAuth<Admin, string>
    {
        EhutBazardbEntities db;
        public AdminRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }

        

        public Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(e => e.Admin_Id == id);

        }

        public List<Admin> GetAll()
        {
            return db.Admins.ToList();
        }

        public void Insert(Admin entity)
        {
            db.Admins.Add(entity);
            db.SaveChanges();
        }

        public void Update(Admin entity)
        {
            var s = db.Admins.FirstOrDefault(en => en.Admin_Id == entity.Admin_Id);
            db.Entry(s).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var s = db.Admins.FirstOrDefault(e => e.Admin_Id == id);
            db.Admins.Remove(s);
            db.SaveChanges();
        }
        ///Login
        public Admin Login(Admin entity)
        {
            var u = db.Admins.FirstOrDefault(en => en.Admin_Username == entity.Admin_Username && en.Admin_Password == entity.Admin_Password);
            return u;
        }




        public Token Authenticate(Admin entity)
        {
            var u = db.Admins.FirstOrDefault(en => en.Admin_Username == entity.Admin_Username && en.Admin_Password == entity.Admin_Password);
            Token t = null;
            if (u != null) //authenticated
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.User_Id = u.Admin_Id;
                t.AccessToken = token;
                t.CreateDate = DateTime.Now;
                t.UserType = "Admin";
                db.Tokens.Add(t);
                db.SaveChanges();

            }
            return t;
        }


        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken.Equals(token) && e.ExpiredDate == null);
            return rs;
        }

        public bool Logout(string token)
        {
            var t = db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token));
            if (t != null)
            {
                t.ExpiredDate = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
