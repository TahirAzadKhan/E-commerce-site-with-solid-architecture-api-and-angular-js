using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class TokenRepo : IRepository<Token, string>
    {
        EhutBazardbEntities db;
        public TokenRepo(EhutBazardbEntities db)
        {
            this.db = db;
        }

        public void Delete(string token)
        {
            db.Tokens.Remove(db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token)));
            db.SaveChanges();
        }

        public Token Get(string token)
        {
            return db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token));
        }

        public List<Token> GetAll()
        {
            return db.Tokens.ToList();
        }

        public void Insert(Token entity)
        {
            db.Tokens.Add(entity);
            db.SaveChanges();
        }

        public void Update(Token entity)
        {
            var token = db.Tokens.FirstOrDefault(en => en.AccessToken.Equals(entity.AccessToken));
            db.Entry(token).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }
    }
}
