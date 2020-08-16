namespace VirtualWork.Persistence.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class AddOwnerToCredentials : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Credentials", "ActorId", c => c.Int(nullable: false));
            AddColumn("dbo.Credentials", "ActorType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Credentials", "ActorType");
            DropColumn("dbo.Credentials", "ActorId");
        }
    }
}
