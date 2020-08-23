using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Messages;
using LanguageService;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service;
using EventDto = VirtualWork.Core.Appointment.Event;

namespace VirtualWork.WinForms.Providers
{
	public class EventListProvider : ListProviderBase<EventDto, Event>
	{
		public const string Events = "Events";

		public EventListProvider(EventRepository eventRepository)
			: base(eventRepository)
		{
		}

		public void GetUpcomingEvents(TreeView treeView)
		{
			GetNodes(treeView, Events, 3, myEvent => myEvent.EventDate.Subtract(DateTime.UtcNow).TotalMilliseconds > 0);
		}

		protected override void ProcessItems(IEnumerable<EventDto> items)
		{
			base.ProcessItems(items);
			foreach (var item in items)
			{
				var notifier = new ActiveSleepNotifier();
				notifier.NotifyAt(item.EventDate,
					() => { InfoBox.Show(Lng.Elem("Upcoming event"), item.ToString()); },
					cancellationToken);
			}
		}
	}
}
