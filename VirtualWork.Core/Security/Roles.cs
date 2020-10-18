namespace VirtualWork.Core.Security
{
	/// <summary>
	/// These roles are the same, which have been created in
	/// VirtualWork\VirtualWork.Persistence\StoredProcedures\CreatePermissions.sql
	/// </summary>
	public static class Roles
	{
		public const string AppointmentCrud = "AppointmentCrud";

		public const string UserAndGroupManagement = "UserAndGroupManagement";

		public const string ResourceCrud = "ResourceCrud";

		public const string IssueCrud = "IssueCrud";

		public const string LogViewer = "LogViewer";		
	}
}
