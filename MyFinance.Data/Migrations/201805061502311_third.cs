namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProviderProducts", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.ProviderProducts", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.ProviderProducts", new[] { "Provider_Id" });
            DropIndex("dbo.ProviderProducts", new[] { "Product_ProductId" });
            DropTable("dbo.Providers");
            DropTable("dbo.ProviderProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProviderProducts",
                c => new
                    {
                        Provider_Id = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Provider_Id, t.Product_ProductId });
            
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
            
            CreateIndex("dbo.ProviderProducts", "Product_ProductId");
            CreateIndex("dbo.ProviderProducts", "Provider_Id");
            AddForeignKey("dbo.ProviderProducts", "Product_ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.ProviderProducts", "Provider_Id", "dbo.Providers", "Id", cascadeDelete: true);
        }
    }
}
