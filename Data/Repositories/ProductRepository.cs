
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;
using Data.Infrastructure;

namespace MyFinance.Data.Repositories
{

    //How to add custom methods to a repository.
    public static class ProductRepository
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


    }
}
