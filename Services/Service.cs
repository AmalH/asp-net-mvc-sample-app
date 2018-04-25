using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        #region Private Fields
        IUnitOfWork utwk;
        #endregion Private Fields

        #region Constructor
        protected Service(IUnitOfWork utwk)
        {
            this.utwk = utwk;
        }
        #endregion Constructor



        public virtual void Add(TEntity entity)
        {
            utwk.getRepository<TEntity>().Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            utwk.getRepository<TEntity>().Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            utwk.getRepository<TEntity>().Delete(entity);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            utwk.getRepository<TEntity>().Delete(where);
        }

        public virtual TEntity GetById(long id)
        {

            return utwk.getRepository<TEntity>().GetById(id);
        }

        public virtual TEntity GetById(string id)
        {
            return utwk.getRepository<TEntity>().GetById(id);
        }

        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, bool>> orderBy = null)
        {
            return utwk.getRepository<TEntity>().GetMany(filter, orderBy);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return utwk.getRepository<TEntity>().Get(where);
        }

        public virtual async Task<int> CountAsync()
        {
            return await utwk.getRepository<TEntity>().CountAsync();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await utwk.getRepository<TEntity>().GetAllAsync();
        }

        public virtual async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match)
        {
            return await utwk.getRepository<TEntity>().FindAsync(match);
        }

        public virtual async Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match)
        {
            return await utwk.getRepository<TEntity>().FindAllAsync(match);
        }



        public void Commit()
        {
            try
            {
                utwk.Commit();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task CommitAsync()
        {
            try
            {
                await utwk.CommitAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Dispose()
        {
            utwk.Dispose();
        }
    }



}
