using Data.Infrastructure;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public static class CategoryRepository
    {
        public static IEnumerable<Product> ProductByCategory(this IRepositoryBaseAsync<Category> repository, int id)
        {
            return repository.GetById(id).Products.AsEnumerable();

        }
        public static IEnumerable<Product> MostExpensiveProductByCategory(this IRepositoryBaseAsync<Category> repository, int id)
        {
            return repository.ProductByCategory(id)
                .OrderByDescending(b => b.Price)
                .Take(5)
                .AsEnumerable();
        }
        public static IEnumerable<Product> GetProductsByCategory(this IRepositoryBaseAsync<Product> repository, string categoryName)
        {
            return repository.GetMany(x => x.Category.Name == categoryName);
        }


    }

}
