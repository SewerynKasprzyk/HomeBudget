namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class full : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "Value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "Value", c => c.String());
        }
    }
}
