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
    public class OperationConfiguration : EntityTypeConfiguration<Operation>
    {
        public OperationConfiguration()
        {
            Property(p => p.DateDebut).IsRequired();
            Property(p => p.DateFin).IsRequired();
            Property(p => p.Duree).IsOptional();


            //Many to Many configuration
            HasMany(p => p.Personnels)
            .WithMany(v => v.Operations)
            .Map(m =>
            {
                m.ToTable("Membre");   //Table d'association
            });


            /*ToTable("MyCategories");
            HasKey(c => c.CategoryId);
            Property(c => c.Name).HasMaxLength(50).IsRequired();*/

        }
    }

}
