namespace VirtualWork.Persistence.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class AddCredentialsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Credentials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Group = c.String(maxLength: 50),
                        ExtraInformation = c.String(maxLength: 1000),
                        Username = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Link = c.String(maxLength: 1000),
                        AlternativeLink = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Credentials");
        }
    }
}
