using System.Data.Entity;
using VirtualWork.Persistence.Migrations;

namespace VirtualWork.Persistence
{
	class Migrator : MigrateDatabaseToLatestVersion<VirtualWorkDatabaseContext, Configuration>
	{
	}
}
