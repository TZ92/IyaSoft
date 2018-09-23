namespace IyaSoft.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeAnnotationsModif4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "AvailableOn", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "AvailableUntil");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "AvailableUntil", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "AvailableOn");
        }
    }
}
