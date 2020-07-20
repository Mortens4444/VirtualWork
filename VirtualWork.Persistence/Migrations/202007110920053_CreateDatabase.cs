namespace VirtualWork.Persistence.Migrations
{
	using System.Data.Entity.Migrations;
	using VirtualWork.Persistence.Helper;

	public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        City = c.String(maxLength: 100),
                        Country = c.String(maxLength: 100),
                        Number = c.String(maxLength: 10),
                        PublicArea = c.String(maxLength: 100),
                        FullAddress = c.String(maxLength: 1000),
                        PublicAreaKind = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        PasswordHash = c.String(maxLength: 128),
                        FullName = c.String(maxLength: 150),
                        OtherInformation = c.String(maxLength: 1000),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Text = c.String(nullable: false, maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Issues", t => t.IssueId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.IssueId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EpicId = c.Int(),
                        CreatorId = c.Int(nullable: false),
                        OwnerId = c.Int(),
                        Description = c.String(maxLength: 1000),
                        Title = c.String(nullable: false, maxLength: 50),
                        CreationDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        Interval = c.Time(nullable: false, precision: 7),
                        IssueType = c.Int(nullable: false),
                        IssueState = c.Int(nullable: false),
                        Priority = c.Int(nullable: false),
                        RepeatInterval = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatorId, cascadeDelete: false)
                .ForeignKey("dbo.Issues", t => t.EpicId)
                .ForeignKey("dbo.Users", t => t.OwnerId)
                .Index(t => t.EpicId)
                .Index(t => t.CreatorId)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.IssueConnections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Issue1Id = c.Int(nullable: false),
                        Issue2Id = c.Int(nullable: false),
                        ConnectionType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Issues", t => t.Issue1Id, cascadeDelete: true)
                .ForeignKey("dbo.Issues", t => t.Issue2Id)
                .Index(t => t.Issue1Id)
                .Index(t => t.Issue2Id);
            
            CreateTable(
                "dbo.IssueHistoryEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueId = c.Int(nullable: false),
                        ModifierUserId = c.Int(nullable: false),
                        ModifyDate = c.DateTime(nullable: false),
                        ModifyInfo = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Issues", t => t.IssueId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ModifierUserId, cascadeDelete: true)
                .Index(t => t.IssueId)
                .Index(t => t.ModifierUserId);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Address = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 1000),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Description = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Licenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Code = c.String(),
                        Description = c.String(),
                        Name = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        RenewalDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.TelephoneNumbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Number = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Content = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Value = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Cameras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServerId = c.Int(),
                        Uri = c.String(),
                        Name = c.String(),
                        Desription = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servers", t => t.ServerId, cascadeDelete: true)
                .Index(t => t.ServerId);
            
            CreateTable(
                "dbo.Servers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IpAddress = c.String(),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatorId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 1000),
                        EventDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(),
                        RepeationValue = c.Int(nullable: false),
                        RepeationType = c.Int(nullable: false),
                        StartApplication = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.CreatorId);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerId = c.Int(nullable: false),
                        Description = c.String(),
                        Title = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        MeetingDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(),
                        RepeationValue = c.Int(nullable: false),
                        RepeationType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.ResourceImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResourceId = c.Int(nullable: false),
                        Content = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Resources", t => t.ResourceId, cascadeDelete: true)
                .Index(t => t.ResourceId);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ResourceType = c.Int(nullable: false),
                        Key = c.String(maxLength: 1000),
                        OtherInformation = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.SystemSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Value = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserIssues",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        IssueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.IssueId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Issues", t => t.IssueId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.IssueId);
            
            CreateTable(
                "dbo.GroupPermissions",
                c => new
                    {
                        GroupId = c.Int(nullable: false),
                        PermissionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GroupId, t.PermissionId })
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.GroupId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.GroupId);

			CreateStoredProcedure("GetUserContacts",
				FileReader.GetEmbeddedFileContent("VirtualWork.Persistence.StoredProcedures.GetUserContacts.sql"),
				new
				{
					UserId = 1
				});
			CreateStoredProcedure("GetUsersAndGroups",
				FileReader.GetEmbeddedFileContent("VirtualWork.Persistence.StoredProcedures.GetUsersAndGroups.sql"));
		}

		public override void Down()
		{
			DropStoredProcedure("GetUserContacts");
			DropStoredProcedure("GetUsersAndGroups");

			DropForeignKey("dbo.ResourceImages", "ResourceId", "dbo.Resources");
            DropForeignKey("dbo.Resources", "UserId", "dbo.Users");
            DropForeignKey("dbo.Meetings", "OwnerId", "dbo.Users");
            DropForeignKey("dbo.Events", "CreatorId", "dbo.Users");
            DropForeignKey("dbo.Cameras", "ServerId", "dbo.Servers");
            DropForeignKey("dbo.UserSettings", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserImages", "UserId", "dbo.Users");
            DropForeignKey("dbo.TelephoneNumbers", "UserId", "dbo.Users");
            DropForeignKey("dbo.Licenses", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserGroups", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.UserGroups", "UserId", "dbo.Users");
            DropForeignKey("dbo.GroupPermissions", "PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.GroupPermissions", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.UserIssues", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.UserIssues", "UserId", "dbo.Users");
            DropForeignKey("dbo.Emails", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.Issues", "OwnerId", "dbo.Users");
            DropForeignKey("dbo.IssueHistoryEntries", "ModifierUserId", "dbo.Users");
            DropForeignKey("dbo.IssueHistoryEntries", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.IssueConnections", "Issue2Id", "dbo.Issues");
            DropForeignKey("dbo.IssueConnections", "Issue1Id", "dbo.Issues");
            DropForeignKey("dbo.Issues", "EpicId", "dbo.Issues");
            DropForeignKey("dbo.Issues", "CreatorId", "dbo.Users");
            DropForeignKey("dbo.Addresses", "UserId", "dbo.Users");
            DropIndex("dbo.UserGroups", new[] { "GroupId" });
            DropIndex("dbo.UserGroups", new[] { "UserId" });
            DropIndex("dbo.GroupPermissions", new[] { "PermissionId" });
            DropIndex("dbo.GroupPermissions", new[] { "GroupId" });
            DropIndex("dbo.UserIssues", new[] { "IssueId" });
            DropIndex("dbo.UserIssues", new[] { "UserId" });
            DropIndex("dbo.Resources", new[] { "UserId" });
            DropIndex("dbo.ResourceImages", new[] { "ResourceId" });
            DropIndex("dbo.Meetings", new[] { "OwnerId" });
            DropIndex("dbo.Events", new[] { "CreatorId" });
            DropIndex("dbo.Cameras", new[] { "ServerId" });
            DropIndex("dbo.UserSettings", new[] { "UserId" });
            DropIndex("dbo.UserImages", new[] { "UserId" });
            DropIndex("dbo.TelephoneNumbers", new[] { "UserId" });
            DropIndex("dbo.Licenses", new[] { "UserId" });
            DropIndex("dbo.Permissions", new[] { "Name" });
            DropIndex("dbo.Groups", new[] { "Name" });
            DropIndex("dbo.Emails", new[] { "UserId" });
            DropIndex("dbo.IssueHistoryEntries", new[] { "ModifierUserId" });
            DropIndex("dbo.IssueHistoryEntries", new[] { "IssueId" });
            DropIndex("dbo.IssueConnections", new[] { "Issue2Id" });
            DropIndex("dbo.IssueConnections", new[] { "Issue1Id" });
            DropIndex("dbo.Issues", new[] { "OwnerId" });
            DropIndex("dbo.Issues", new[] { "CreatorId" });
            DropIndex("dbo.Issues", new[] { "EpicId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "IssueId" });
            DropIndex("dbo.Users", new[] { "Name" });
            DropIndex("dbo.Addresses", new[] { "UserId" });
            DropTable("dbo.UserGroups");
            DropTable("dbo.GroupPermissions");
            DropTable("dbo.UserIssues");
            DropTable("dbo.SystemSettings");
            DropTable("dbo.Resources");
            DropTable("dbo.ResourceImages");
            DropTable("dbo.Meetings");
            DropTable("dbo.Events");
            DropTable("dbo.Servers");
            DropTable("dbo.Cameras");
            DropTable("dbo.UserSettings");
            DropTable("dbo.UserImages");
            DropTable("dbo.TelephoneNumbers");
            DropTable("dbo.Licenses");
            DropTable("dbo.Permissions");
            DropTable("dbo.Groups");
            DropTable("dbo.Emails");
            DropTable("dbo.IssueHistoryEntries");
            DropTable("dbo.IssueConnections");
            DropTable("dbo.Issues");
            DropTable("dbo.Comments");
            DropTable("dbo.Users");
            DropTable("dbo.Addresses");
        }
    }
}
