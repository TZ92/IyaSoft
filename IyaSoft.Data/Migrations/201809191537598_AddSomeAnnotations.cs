namespace IyaSoft.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
