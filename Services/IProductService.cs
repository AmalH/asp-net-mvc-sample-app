using Data.Infrastructure;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class IProductService : IService<Product>
    {


        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<Func<Product, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> FindAllAsync(System.Linq.Expressions.Expression<Func<Product, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<Product> FindAsync(System.Linq.Expressions.Expression<Func<Product, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Product Get(System.Linq.Expressions.Expression<Func<Product, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetMany(System.Linq.Expressions.Expression<Func<Product, bool>> where = null, System.Linq.Expressions.Expression<Func<Product, bool>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

}
