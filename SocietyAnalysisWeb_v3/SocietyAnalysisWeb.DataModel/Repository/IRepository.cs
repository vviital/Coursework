using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SocietyAnalysisWeb.DataModel.Repository
{
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Delete(Expression<Func<TEntity, bool>> where);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        TEntity Get(Expression<Func<TEntity, bool>> where);
        
        int Count(Expression<Func<TEntity, bool>> where = null);

        bool IsExist(Expression<Func<TEntity, bool>> where = null);

        void Save();

        void Dispose();
    }
}
