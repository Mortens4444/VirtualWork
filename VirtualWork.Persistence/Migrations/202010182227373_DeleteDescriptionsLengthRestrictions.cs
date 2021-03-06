﻿namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDescriptionsLengthRestrictions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Issues", "Description", c => c.String());
            AlterColumn("dbo.Groups", "Description", c => c.String());
            AlterColumn("dbo.Permissions", "Description", c => c.String());
            AlterColumn("dbo.Events", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Permissions", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Groups", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Issues", "Description", c => c.String(maxLength: 1000));
        }
    }
}
