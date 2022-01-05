using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TEntity,ID>
    {

        List<TEntity> GetAll();
        TEntity Get(ID id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(ID id);
        
    }
}
