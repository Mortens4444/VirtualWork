using System;
using System.Windows.Forms;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.Repositories;

using MeetingDto = VirtualWork.Core.Appointment.Meeting;

namespace VirtualWork.WinForms.Providers
{
	public class MeetingsListProvider : ListProviderBase<MeetingDto, Meeting>
	{
		public MeetingsListProvider(MeetingRepository meetingRepository)
			: base(meetingRepository)
		{
		}

		public void GetUpcomingMeetings(TreeView treeView)
		{
			base.GetNodes(treeView, "Meetings", 2, meeting => meeting.MeetingDate.Subtract(DateTime.UtcNow).TotalMilliseconds > 0);
		}
	}
}

