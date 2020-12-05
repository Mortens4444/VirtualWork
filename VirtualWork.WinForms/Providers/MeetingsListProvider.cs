using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Messages;
using LanguageService;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Log;
using VirtualWork.Persistence.Entities;
using VirtualWork.Service;
using MeetingDto = VirtualWork.Core.Appointment.Meeting;
using MeetingRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Meeting, VirtualWork.Persistence.Entities.Meeting>;

namespace VirtualWork.WinForms.Providers
{
	public class MeetingsListProvider : ListProviderBase<MeetingDto, Meeting>
	{
		public const string Meetings = "Meetings";

		public MeetingsListProvider(MeetingRepository meetingRepository,
			ILogger logger)
			: base(meetingRepository, logger)
		{
		}

		public void GetUpcomingMeetings(TreeView treeView)
		{
			base.GetNodes(treeView, Meetings, 2,
				meeting => meeting.MeetingDate >= DateTime.UtcNow ||
					(meeting.ExpirationDate.HasValue && meeting.ExpirationDate > DateTime.UtcNow) ||
					(meeting.RepetitionType != (int)RepetitionType.NoRepeat) && !meeting.ExpirationDate.HasValue);
		}

		protected override void ProcessItems(IEnumerable<MeetingDto> items)
		{
			base.ProcessItems(items);
			foreach (var item in items)
			{
				var notifier = new ActiveSleepNotifier(logger);
				notifier.NotifyAt(item,
					() => { InfoBox.Show(Lng.Elem("Upcoming meeting"), item.ToString()); },
					cancellationToken);
			}
		}

	}
}

