using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using MeetingDto = VirtualWork.Core.Appointment.Meeting;

namespace VirtualWork.Persistence.Repositories
{
	public class MeetingRepository : RepositoryBase<MeetingDto, Meeting>
    {
        public MeetingRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			MeetingConverter meetingConverter)
            : base(mtfDatabase, meetingConverter, mtfDatabase.Meetings)
        {
        }
	}
}
