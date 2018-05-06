using Data;
using MyFinance.Domain.Entities;
using Services;
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
            /* MyFinanceContext context = new MyFinanceContext();
             context.Products.Add(new Product { Name = "Pomme de terre", Category = new Category { Name = "AA" } });
             context.SaveChanges(); */




            /********************* services *****************/

            IProductService MyService = new ProductService();
            MyService.Add(new Product { Name = "Pomme de terre", Category = new Category { Name = "AA" } });
            MyService.Commit();

            /* IOperationService oprtService = new OperationService();
             IEnumerable<Operation> result = ((OperationService)oprtService).GetOperationsReussies();
             oprtService.Commit();
             System.Console.Write("Res: " + result);
             System.Console.ReadLine();*/



        }
    }
}
