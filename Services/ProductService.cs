using Data.Infrastructure;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : Service<Product> , IProductService
        // IProductService
    {


        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ProductService(): base(ut)
        {
        }
    }


}
