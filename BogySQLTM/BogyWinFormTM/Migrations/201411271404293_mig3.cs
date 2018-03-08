namespace BogyWinFormTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MTasks", "Users_UserId", "dbo.Users");
            DropIndex("dbo.MTasks", new[] { "Users_UserId" });
            DropColumn("dbo.MTasks", "Users_UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MTasks", "Users_UserId", c => c.Int());
            CreateIndex("dbo.MTasks", "Users_UserId");
            AddForeignKey("dbo.MTasks", "Users_UserId", "dbo.Users", "UserId");
        }
    }
}
