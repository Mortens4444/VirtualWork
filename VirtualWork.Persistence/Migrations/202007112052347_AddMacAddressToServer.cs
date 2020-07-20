namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMacAddressToServer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Servers", "MacAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Servers", "MacAddress");
        }
    }
}
