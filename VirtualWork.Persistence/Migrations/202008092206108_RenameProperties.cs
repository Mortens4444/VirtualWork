namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameProperties : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Issues", name: "EpicId", newName: "ParentId");
            RenameIndex(table: "dbo.Issues", name: "IX_EpicId", newName: "IX_ParentId");
            AddColumn("dbo.Addresses", "EntityId", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "EntityType", c => c.Int(nullable: false));
            DropColumn("dbo.Addresses", "ActorId");
            DropColumn("dbo.Addresses", "ActorType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "ActorType", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "ActorId", c => c.Int(nullable: false));
            DropColumn("dbo.Addresses", "EntityType");
            DropColumn("dbo.Addresses", "EntityId");
            RenameIndex(table: "dbo.Issues", name: "IX_ParentId", newName: "IX_EpicId");
            RenameColumn(table: "dbo.Issues", name: "ParentId", newName: "EpicId");
        }
    }
}
