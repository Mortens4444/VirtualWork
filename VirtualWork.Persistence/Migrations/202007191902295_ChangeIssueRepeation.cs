namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIssueRepeation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Issues", "ExpirationDate", c => c.DateTime());
            AddColumn("dbo.Issues", "RepeationValue", c => c.Int(nullable: false));
            AddColumn("dbo.Issues", "RepeationType", c => c.Int(nullable: false));
            DropColumn("dbo.Issues", "RepeatInterval");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Issues", "RepeatInterval", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Issues", "RepeationType");
            DropColumn("dbo.Issues", "RepeationValue");
            DropColumn("dbo.Issues", "ExpirationDate");
        }
    }
}
