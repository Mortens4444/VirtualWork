namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Issues", "RepetitionValue", c => c.Int(nullable: false));
            AddColumn("dbo.Issues", "RepetitionType", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "RepetitionValue", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "RepetitionType", c => c.Int(nullable: false));
            AddColumn("dbo.Meetings", "RepetitionValue", c => c.Int(nullable: false));
            AddColumn("dbo.Meetings", "RepetitionType", c => c.Int(nullable: false));
            DropColumn("dbo.Issues", "RepeationValue");
            DropColumn("dbo.Issues", "RepeationType");
            DropColumn("dbo.Events", "RepeationValue");
            DropColumn("dbo.Events", "RepeationType");
            DropColumn("dbo.Meetings", "RepeationValue");
            DropColumn("dbo.Meetings", "RepeationType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Meetings", "RepeationType", c => c.Int(nullable: false));
            AddColumn("dbo.Meetings", "RepeationValue", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "RepeationType", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "RepeationValue", c => c.Int(nullable: false));
            AddColumn("dbo.Issues", "RepeationType", c => c.Int(nullable: false));
            AddColumn("dbo.Issues", "RepeationValue", c => c.Int(nullable: false));
            DropColumn("dbo.Meetings", "RepetitionType");
            DropColumn("dbo.Meetings", "RepetitionValue");
            DropColumn("dbo.Events", "RepetitionType");
            DropColumn("dbo.Events", "RepetitionValue");
            DropColumn("dbo.Issues", "RepetitionType");
            DropColumn("dbo.Issues", "RepetitionValue");
        }
    }
}
