using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext() : base("Name=DefaultConnection")  
        {
            Database.SetInitializer<MyFinanceContext>(new MyFinanceContextInitializer());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }


        public class MyFinanceContextInitializer : DropCreateDatabaseIfModelChanges<MyFinanceContext>
        {
            protected override void Seed(MyFinanceContext context)
            {
                var listCategories = new List<Category>{
                new Category{Name="Meds" },
                new Category{Name="Clothing" },
                new Category{Name="Furniture" },
            };
                context.Categories.AddRange(listCategories);
                context.SaveChanges();
            }
        }


    }
}
