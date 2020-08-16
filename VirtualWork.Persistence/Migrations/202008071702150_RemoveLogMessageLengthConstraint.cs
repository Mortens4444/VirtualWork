namespace VirtualWork.Persistence.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class RemoveLogMessageLengthConstraint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LogEntries", "Message", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LogEntries", "Message", c => c.String(maxLength: 1000));
        }
    }
}
