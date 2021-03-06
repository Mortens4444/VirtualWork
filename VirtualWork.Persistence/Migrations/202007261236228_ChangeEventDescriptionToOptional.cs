﻿namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEventDescriptionToOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Description", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Description", c => c.String(nullable: false, maxLength: 1000));
        }
    }
}
