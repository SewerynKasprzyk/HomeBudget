namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserGoal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Goals", "User_Id", c => c.Long());
            CreateIndex("dbo.Goals", "User_Id");
            AddForeignKey("dbo.Goals", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "User_Id", "dbo.Users");
            DropIndex("dbo.Goals", new[] { "User_Id" });
            DropColumn("dbo.Goals", "User_Id");
        }
    }
}
