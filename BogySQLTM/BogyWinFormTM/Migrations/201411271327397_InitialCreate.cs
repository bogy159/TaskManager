namespace BogyWinFormTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MTasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Creator = c.Int(nullable: false),
                        EstTime = c.Int(nullable: false),
                        Assigned = c.Int(nullable: false),
                        CreTime = c.DateTime(nullable: false),
                        Final = c.Boolean(nullable: false),
                        Users_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.TaskId)
                .ForeignKey("dbo.Users", t => t.Users_UserId)
                .Index(t => t.Users_UserId);
            
            CreateTable(
                "dbo.TimeSpents",
                c => new
                    {
                        TSId = c.Int(nullable: false, identity: true),
                        TheAssi = c.Int(nullable: false),
                        TheTask = c.Int(nullable: false),
                        FinTime = c.DateTime(nullable: false),
                        Hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TSId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Pass = c.String(),
                        FName = c.String(),
                        LName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.TimeSpentMTasks",
                c => new
                    {
                        TimeSpent_TSId = c.Int(nullable: false),
                        MTasks_TaskId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TimeSpent_TSId, t.MTasks_TaskId })
                .ForeignKey("dbo.TimeSpents", t => t.TimeSpent_TSId, cascadeDelete: true)
                .ForeignKey("dbo.MTasks", t => t.MTasks_TaskId, cascadeDelete: true)
                .Index(t => t.TimeSpent_TSId)
                .Index(t => t.MTasks_TaskId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MTasks", "Users_UserId", "dbo.Users");
            DropForeignKey("dbo.TimeSpentMTasks", "MTasks_TaskId", "dbo.MTasks");
            DropForeignKey("dbo.TimeSpentMTasks", "TimeSpent_TSId", "dbo.TimeSpents");
            DropIndex("dbo.TimeSpentMTasks", new[] { "MTasks_TaskId" });
            DropIndex("dbo.TimeSpentMTasks", new[] { "TimeSpent_TSId" });
            DropIndex("dbo.MTasks", new[] { "Users_UserId" });
            DropTable("dbo.TimeSpentMTasks");
            DropTable("dbo.Users");
            DropTable("dbo.TimeSpents");
            DropTable("dbo.MTasks");
        }
    }
}
