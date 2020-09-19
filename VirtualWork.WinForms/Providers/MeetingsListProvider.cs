﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Messages;
using LanguageService;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Entities;
using VirtualWork.Service;
using MeetingDto = VirtualWork.Core.Appointment.Meeting;
using MeetingRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Meeting, VirtualWork.Persistence.Entities.Meeting>;

namespace VirtualWork.WinForms.Providers
{
	public class MeetingsListProvider : ListProviderBase<MeetingDto, Meeting>
	{
		public const string Meetings = "Meetings";

		public MeetingsListProvider(MeetingRepository meetingRepository)
			: base(meetingRepository)
		{
		}

		public void GetUpcomingMeetings(TreeView treeView)
		{
			base.GetNodes(treeView, Meetings, 2,
				meeting => meeting.MeetingDate.Subtract(DateTime.UtcNow).TotalMilliseconds > 0 ||
					(meeting.ExpirationDate.HasValue && meeting.ExpirationDate > DateTime.Now) ||
					(meeting.RepetitionType != (int)RepetitionType.NoRepeat) && !meeting.ExpirationDate.HasValue);
		}

		protected override void ProcessItems(IEnumerable<MeetingDto> items)
		{
			base.ProcessItems(items);
			foreach (var item in items)
			{
				var notifier = new ActiveSleepNotifier();
				notifier.NotifyAt(item,
					() => { InfoBox.Show(Lng.Elem("Upcoming meeting"), item.ToString()); },
					cancellationToken);
			}
		}

	}
}

