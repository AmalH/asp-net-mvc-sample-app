namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ImageName = c.String(),
                        DateProd = c.DateTime(nullable: false),
                        CategoryId = c.Int(),
                        Herbs = c.String(),
                        LabName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProviderProducts",
                c => new
                    {
                        Provider_Id = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Provider_Id, t.Product_ProductId })
                .ForeignKey("dbo.Providers", t => t.Provider_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Provider_Id)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProviderProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.ProviderProducts", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ProviderProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.ProviderProducts", new[] { "Provider_Id" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.ProviderProducts");
            DropTable("dbo.Providers");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
        }
    }
}
