namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntroduceAppointmentEndDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Meetings", "MeetingEndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Meetings", "MeetingEndDate");
            DropColumn("dbo.Events", "EventEndDate");
        }
    }
}
