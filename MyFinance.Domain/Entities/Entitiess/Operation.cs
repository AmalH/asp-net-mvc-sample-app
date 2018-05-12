using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities.Entitiess
{
    public class Operation
    {

        public int OperationId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int Duree { get; set; }
        public bool Etat { get; set; }


        public virtual Patient Patient { get; set; }
        public virtual ICollection<Personnel> Personnels { get; set; }


    }
}
