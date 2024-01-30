namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Balances",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Limit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Date = c.DateTime(nullable: false),
                        Category_Id = c.Int(),
                        User_Id = c.Int(),
                        Balance_Id = c.Int(),
                        BalanceWhole_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Balances", t => t.Balance_Id)
                .ForeignKey("dbo.BalanceWholes", t => t.BalanceWhole_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Balance_Id)
                .Index(t => t.BalanceWhole_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Limit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Role = c.Int(nullable: false),
                        Limit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.BalanceWholes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Limit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "BalanceWhole_Id", "dbo.BalanceWholes");
            DropForeignKey("dbo.Goals", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Balances", "Id", "dbo.Users");
            DropForeignKey("dbo.Transactions", "Balance_Id", "dbo.Balances");
            DropForeignKey("dbo.Transactions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Transactions", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Goals", new[] { "User_Id" });
            DropIndex("dbo.Transactions", new[] { "BalanceWhole_Id" });
            DropIndex("dbo.Transactions", new[] { "Balance_Id" });
            DropIndex("dbo.Transactions", new[] { "User_Id" });
            DropIndex("dbo.Transactions", new[] { "Category_Id" });
            DropIndex("dbo.Balances", new[] { "Id" });
            DropTable("dbo.BalanceWholes");
            DropTable("dbo.Goals");
            DropTable("dbo.Users");
            DropTable("dbo.Categories");
            DropTable("dbo.Transactions");
            DropTable("dbo.Balances");
        }
    }
}
