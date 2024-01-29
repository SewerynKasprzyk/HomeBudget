namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepairedAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Goals", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Goals", "Amonunt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Goals", "Amonunt", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Goals", "Amount");
        }
    }
}
