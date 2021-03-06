﻿namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteResourceOtherInformationLengthRestriction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resources", "OtherInformation", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resources", "OtherInformation", c => c.String(maxLength: 1000));
        }
    }
}
