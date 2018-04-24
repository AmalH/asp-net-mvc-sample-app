namespace Data.Migrations
{
    using MyFinance.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.MyFinanceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Data.MyFinanceContext";
        }

        protected override void Seed(Data.MyFinanceContext context)
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
