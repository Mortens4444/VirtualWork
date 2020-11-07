using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Messages;
using LanguageService;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Entities;
using VirtualWork.Service;
using VirtualWork.Service.Process;
using EventDto = VirtualWork.Core.Appointment.Event;
using EventRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Event, VirtualWork.Persistence.Entities.Event>;

namespace VirtualWork.WinForms.Providers
{
	public class EventListProvider : ListProviderBase<EventDto, Event>
	{
		public const string Events = "Events";
		private readonly ProcessUtils processUtils;

		public EventListProvider(EventRepository eventRepository,
			ProcessUtils processUtils)
			: base(eventRepository)
		{
			this.processUtils = processUtils;
		}

		public void GetUpcomingEvents(TreeView treeView)
		{
			GetNodes(treeView, Events, 3,
				myEvent => myEvent.EventDate >= DateTime.UtcNow ||
					(myEvent.ExpirationDate.HasValue && myEvent.ExpirationDate > DateTime.UtcNow) ||
					(myEvent.RepetitionType != (int)RepetitionType.NoRepeat) && !myEvent.ExpirationDate.HasValue);
		}

		protected override void ProcessItems(IEnumerable<EventDto> items)
		{
			base.ProcessItems(items);
			foreach (var item in items)
			{
				var notifier = new ActiveSleepNotifier();
				notifier.NotifyAt(item,
					() =>
					{
						if (!String.IsNullOrWhiteSpace(item.ApplicationToStart))
						{
							processUtils.Start(item.ApplicationToStart, item.Arguments);
						}
						else
						{
							InfoBox.Show(Lng.Elem("Upcoming event"), item.ToString());
						}
					},
					cancellationToken);
			}
		}
	}
}
