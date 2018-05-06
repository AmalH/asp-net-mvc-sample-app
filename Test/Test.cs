using Data;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {

            /********************* entity framework *****************/
            MyFinanceContext context = new MyFinanceContext();
            context.Products.Add(new Product { Name = "Pomme de terre", Category = new Category { Name = "AA" } });
            context.SaveChanges();




            /********************* services *****************/
        }
    }
}
