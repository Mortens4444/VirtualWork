using System;
using System.Windows.Forms;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Repositories;

using EventDto = VirtualWork.Core.Appointment.Event;

namespace VirtualWork.WinForms.Providers
{
	public class EventListProvider : ListProviderBase<EventDto, Event>
	{
		public EventListProvider(EventRepository eventRepository)
			: base(eventRepository)
		{
		}

		public void GetUpcomingEvents(TreeView treeView)
		{
			GetNodes(treeView, "Events", 3, myEvent => myEvent.EventDate.Subtract(DateTime.UtcNow).TotalMilliseconds > 0);
		}
	}
}
