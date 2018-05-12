using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;
using MyFinance.Domain.Entities.Entitiess;

namespace MyFinance.Data.Configurations
{
    public class PatientConfiguration : EntityTypeConfiguration<Patient>
    {
        public PatientConfiguration()
        {
            //Property(p => p.Cin).Ha

        }
    }

}
