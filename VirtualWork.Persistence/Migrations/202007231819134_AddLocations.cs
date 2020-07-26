namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventLocation", c => c.String(maxLength: 1000));
            AddColumn("dbo.Meetings", "MeetingPoint", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Meetings", "MeetingPoint");
            DropColumn("dbo.Events", "EventLocation");
        }
    }
}
