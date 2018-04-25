namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotationsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "LabAddress_StreetAddress", c => c.String());
            AddColumn("dbo.Products", "LabAddress_City", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Providers", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Providers", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Providers", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Providers", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Providers", "Email", c => c.String());
            AlterColumn("dbo.Providers", "Password", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            DropColumn("dbo.Products", "LabAddress_City");
            DropColumn("dbo.Products", "LabAddress_StreetAddress");
        }
    }
}
