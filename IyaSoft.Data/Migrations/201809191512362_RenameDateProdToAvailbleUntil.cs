namespace IyaSoft.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDateProdToAvailbleUntil : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "AvailableUntil", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "DateProd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "DateProd", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "AvailableUntil");
        }
    }
}
