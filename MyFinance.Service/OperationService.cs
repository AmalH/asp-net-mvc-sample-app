using MyFinance.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;
using MyFinance.Data.Repositories;
using MyFinance.Data;
using Service.Pattern;
using MyFinance.Domain.Entities.Entitiess;

namespace MyFinance.Service
{
    public class OperationService : Service<Operation>, IOperationService
    {
       
       
        private static IDatabaseFactory dbf =  new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public OperationService(): base(ut)
        {
        }
        public IEnumerable<Operation> GetOperationsReussies()
        {
            return ut.getRepository<Operation>().GetMany(x => x.Etat);
        }

        public void AddOperation(Operation o)
        {
            ut.getRepository<Operation>().Add(o);
        }

        public IEnumerable<Operation> GetAllOperations()
        {
            return ut.getRepository<Operation>().GetMany();
        }





    }

}
