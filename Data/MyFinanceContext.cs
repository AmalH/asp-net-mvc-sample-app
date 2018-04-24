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
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }


        public class MyFinanceContextInitializer : DropCreateDatabaseIfModelChanges<MyFinanceContext>
        {
            protected override void Seed(MyFinanceContext context)
            {
                var listCategories = new List<Category>{
                new Category{Name="Medicament" },
                new Category{Name="Vetement" },
                new Category{Name="Meuble" },
            };

                context.Categories.AddRange(listCategories);
                context.SaveChanges();
            }
        }


    }
}
