namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeForeignKeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        FullName = c.String(maxLength: 150),
                        OtherInformation = c.String(maxLength: 1000),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Partners", new[] { "Name" });
            DropTable("dbo.Partners");
        }
    }
}
