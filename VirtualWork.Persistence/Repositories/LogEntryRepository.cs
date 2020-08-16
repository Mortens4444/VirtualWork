using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using LogEntryDto = VirtualWork.Core.Log.LogEntry;

namespace VirtualWork.Persistence.Repositories
{
	public class LogEntryRepository : RepositoryBase<LogEntryDto, LogEntry>
    {
        public LogEntryRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			LogEntryConverter logEntryConverter)
            : base(mtfDatabase, logEntryConverter, mtfDatabase.LogEntries)
        {
        }
	}
}
