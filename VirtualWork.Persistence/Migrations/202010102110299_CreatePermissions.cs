namespace VirtualWork.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
	using VirtualWork.Persistence.Helper;

	public partial class CreatePermissions : DbMigration
    {
        public override void Up()
        {
			var createPermissionsSqlScript = FileReader.GetEmbeddedFileContent("VirtualWork.Persistence.StoredProcedures.CreatePermissions.sql");
			Sql(createPermissionsSqlScript);
		}
        
        public override void Down()
        {
			Sql("TRUNCATE TABLE [Permissions]");
        }
    }
}
