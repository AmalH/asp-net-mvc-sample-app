using MyFinance.Domain.Entities.Entitiess;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configurations
{
    public class PersonnelConfiguration : EntityTypeConfiguration<Personnel>
    {
        public PersonnelConfiguration()
        {
          
            //Inheritance
            Map<Chirurgien>(c =>
            {
                c.Requires("IsChirurgien").HasValue(1);  //isBiological is the descreminator
            });
            Map<EquipePluridisciplinaire>(c =>
            {
                c.Requires("IsChirurgien").HasValue(0);
            });
        }
    }
}

