using MyFinance.Domain.Entities.Entitiess;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Data.Infrastructure;

namespace MyFinance.Service
{
    public class ChirurgienService : Service<Chirurgien>, IChirurgienService
    {


        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);


        public ChirurgienService() : base(ut)
        {
        }

        public List<Chirurgien> GetChirurgiensNonReussis()
        {
            List<Chirurgien> res = new List<Chirurgien>();
            Boolean isFailed = false;
            (ut.getRepository<Chirurgien>().GetMany()).ToList().ForEach(c => {
                c.Operations.ToList().ForEach(o =>
                {
                    if (o.Etat == false)
                        isFailed = true;
                }
                    );
                if (isFailed)
                    res.Add(c);

            });
            return res;
               
        }

        public void AddChirurgien(Chirurgien g)
        {
            ut.getRepository<Chirurgien>().Add(g);
        }

    }
}
