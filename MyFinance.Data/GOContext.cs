using MyFinance.Data.Configurations;
using MyFinance.Data.CustumConventions;
using MyFinance.Domain.Entities;
using MyFinance.Domain.Entities.Entitiess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
    public class GOContext : DbContext
    {
        public GOContext():base("name= GOBD")
        {

            /* dropCreateStrategy **/
             Database.SetInitializer<GOContext>(new DropCreateDatabaseIfModelChanges<GOContext>());        


            /** personalized strategy **/
            // Database.SetInitializer<GOContext>(new GOContextInitializer());
        }


        /** les db sets **/
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Personnel> Personnels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonnelConfiguration());
            modelBuilder.Configurations.Add(new PatientConfiguration());
            modelBuilder.Configurations.Add(new OperationConfiguration());
        }

    }

    /**  personnalized database creation strategy **/
    public class GOContextInitializer : DropCreateDatabaseIfModelChanges<GOContext>
    {
        protected override void Seed(GOContext context)
        {
           /* var listCategories = new List<Category>{
            	new Category{Name="Medicament" },
            	new Category{Name="Vetement" },
            	new Category{Name="Meuble" },                   	
        	};

            context.Categories.AddRange(listCategories);
            context.SaveChanges();*/
        }
    }


}
