using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModel.Repository;

namespace SocietyAnalysisWeb.DataBase.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected SocietyContext _societyContext;

        protected DbSet<TEntity> DbSet
        {
            get { return _societyContext.Set<TEntity>(); }
        }

        public BaseRepository(SocietyContext context)
        {
            _societyContext = context;
        }

        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            _societyContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            IQueryable<TEntity> entities = DbSet.Where(where);
            List<TEntity> objects = entities.ToList();
            foreach (var entity in objects)
            {
                DbSet.Remove(entity);
            }
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return DbSet.Where(where).ToList();
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return DbSet.Where(where).FirstOrDefault<TEntity>();
        }

        public int Count(Expression<Func<TEntity, bool>> where = null)
        {
            return DbSet.Count(where);
        }

        public bool IsExist(Expression<Func<TEntity, bool>> where = null)
        {
            return DbSet.FirstOrDefault(where) != null;
        }

        public void Save()
        {
            try
            {
                _societyContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                StringBuilder builder = new StringBuilder();
                foreach (var errors in e.EntityValidationErrors)
                {
                    builder.Append(string.Format(
                        "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        errors.Entry.Entity.GetType().Name, errors.Entry.State) + Environment.NewLine);
                    foreach (var dbValidationError in errors.ValidationErrors)
                    {
                        builder.Append(string.Format("- Property: \"{0}\", Error: \"{1}\"",
                        dbValidationError.PropertyName, dbValidationError.ErrorMessage));
                    }
                }
                throw new Exception(builder.ToString(), e);
            }
        }

        public void Dispose()
        {
            if (_societyContext != null)
            {
                _societyContext.Dispose();
                _societyContext = null;
            }
        }
    }
}
