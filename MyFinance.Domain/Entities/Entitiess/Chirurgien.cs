using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities.Entitiess
{
    public class Chirurgien : Personnel
    {

        public int Nbre_annee_exp { get; set; }
        public int Note_xp { get; set; }

    }
}
