namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeStampToLogEntry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogEntries", "TimeStamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LogEntries", "TimeStamp");
        }
    }
}
