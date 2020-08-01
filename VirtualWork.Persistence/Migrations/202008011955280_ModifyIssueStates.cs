namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyIssueStates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Issues", "IsVerified", c => c.Boolean(nullable: false));
            AddColumn("dbo.Issues", "IsBlocked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Issues", "IsBlocked");
            DropColumn("dbo.Issues", "IsVerified");
        }
    }
}
