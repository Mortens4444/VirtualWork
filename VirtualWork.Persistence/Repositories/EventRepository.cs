using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using EventDto = VirtualWork.Core.Appointment.Event;

namespace VirtualWork.Persistence.Repositories
{
	public class EventRepository : RepositoryBase<EventDto, Event>
    {
        public EventRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			EventConverter eventConverter)
            : base(mtfDatabase, eventConverter, mtfDatabase.Events)
        {
        }
	}
}
