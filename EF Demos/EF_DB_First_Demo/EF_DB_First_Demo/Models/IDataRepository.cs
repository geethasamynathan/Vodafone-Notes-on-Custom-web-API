using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_DB_First_Demo.Models
{
   public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        //TEntity Get(long id);
        ////TDTO GetDto(long id);
        void Add(TEntity entity);
        //void Update(TEntity entityToUpdate, TEntity entity);
        //void Delete(TEntity entity);
    }
}
