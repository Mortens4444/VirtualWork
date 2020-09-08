namespace VirtualWork.Persistence.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class MergeImageEntities : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ResourceImages", "ResourceId", "dbo.Resources");
            DropIndex("dbo.ResourceImages", new[] { "ResourceId" });
            CreateTable(
                "dbo.EntityImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageBytes = c.Binary(),
                        EntityId = c.Int(nullable: false),
                        EntityType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ResourceImages");
            DropTable("dbo.ActorImages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ActorImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActorId = c.Int(nullable: false),
                        ActorType = c.Int(nullable: false),
                        Content = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ResourceImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResourceId = c.Int(nullable: false),
                        Content = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.EntityImages");
            CreateIndex("dbo.ResourceImages", "ResourceId");
            AddForeignKey("dbo.ResourceImages", "ResourceId", "dbo.Resources", "Id", cascadeDelete: true);
        }
    }
}
