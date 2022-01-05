using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAuth<TEntity, ID>
    {
        Token Authenticate(TEntity entity);
        bool IsAuthenticated(string token);
        bool Logout(string token);
    }
}
