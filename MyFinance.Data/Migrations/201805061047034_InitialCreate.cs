namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        OperationId = c.Int(nullable: false, identity: true),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Duree = c.Int(),
                        Etat = c.Boolean(nullable: false),
                        Patient_Cin = c.Int(),
                    })
                .PrimaryKey(t => t.OperationId)
                .ForeignKey("dbo.Patients", t => t.Patient_Cin)
                .Index(t => t.Patient_Cin);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Cin = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Adress = c.String(),
                        Description = c.String(),
                        NomComplet_firstName = c.String(),
                        NomComplet_lastName = c.String(),
                    })
                .PrimaryKey(t => t.Cin);
            
            CreateTable(
                "dbo.Personnels",
                c => new
                    {
                        CodePersonnel = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        NomComplet_firstName = c.String(),
                        NomComplet_lastName = c.String(),
                        Address_Rue = c.String(),
                        Address_Ville = c.String(),
                        Nbre_annee_exp = c.Int(),
                        Note_xp = c.Int(),
                        Specialite = c.String(),
                        IsChirurgien = c.Int(),
                    })
                .PrimaryKey(t => t.CodePersonnel);
            
            CreateTable(
                "dbo.Membre",
                c => new
                    {
                        Operation_OperationId = c.Int(nullable: false),
                        Personnel_CodePersonnel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Operation_OperationId, t.Personnel_CodePersonnel })
                .ForeignKey("dbo.Operations", t => t.Operation_OperationId, cascadeDelete: true)
                .ForeignKey("dbo.Personnels", t => t.Personnel_CodePersonnel, cascadeDelete: true)
                .Index(t => t.Operation_OperationId)
                .Index(t => t.Personnel_CodePersonnel);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Membre", "Personnel_CodePersonnel", "dbo.Personnels");
            DropForeignKey("dbo.Membre", "Operation_OperationId", "dbo.Operations");
            DropForeignKey("dbo.Operations", "Patient_Cin", "dbo.Patients");
            DropIndex("dbo.Membre", new[] { "Personnel_CodePersonnel" });
            DropIndex("dbo.Membre", new[] { "Operation_OperationId" });
            DropIndex("dbo.Operations", new[] { "Patient_Cin" });
            DropTable("dbo.Membre");
            DropTable("dbo.Personnels");
            DropTable("dbo.Patients");
            DropTable("dbo.Operations");
        }
    }
}
