using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VirtualWork.Core.Extensions;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms.Providers
{
	public class CalendarItemsProvider
	{
		private const string FontFamily = "Arial";
		private readonly MeetingRepository meetingRepository;
		private readonly EventRepository eventRepository;

		public CalendarItemsProvider(MeetingRepository meetingRepository,
			EventRepository eventRepository)
		{
			this.meetingRepository = meetingRepository;
			this.eventRepository = eventRepository;
		}

		private readonly TimeSpan HalfAnHour = new TimeSpan(0, 30, 0);
		private readonly DataGridViewCellStyle hourStyle = new DataGridViewCellStyle()
		{
			Alignment = DataGridViewContentAlignment.MiddleLeft,
			BackColor = Color.LightGray,
			Font = new Font(FontFamily, 10)
		};

		private readonly DataGridViewCellStyle halfAnHourStyle = new DataGridViewCellStyle()
		{
			Alignment = DataGridViewContentAlignment.TopRight,
			Font = new Font(FontFamily, 8)
		};

		public void GetItems(DataGridView dgvCalendar, DateTime date)
		{
			dgvCalendar.Rows.Clear();
			var meetings = meetingRepository.GetAll(meeting => meeting.MeetingDate.IsDateTimeTheSameAs(date));
			var events = eventRepository.GetAll(myEvent => myEvent.EventDate.IsDateTimeTheSameAs(date));

			var slotStartTime = new TimeSpan(0, 0, 0);
			for (int i = 0; i < 48; i++)
			{
				var slotEndTime = slotStartTime.Add(HalfAnHour);
				var slotMeetings = meetings.Where(meeting => meeting.MeetingDate.IsDateTimeBetweenTimeSpans(slotStartTime, slotEndTime))
					.Select(meeting => meeting.Title);
				var slotEvents = events.Where(myEvent => myEvent.EventDate.IsDateTimeBetweenTimeSpans(slotStartTime, slotEndTime))
					.Select(myEvent => myEvent.Title);

				var formatString = i % 2 == 0 ? "hh\\:mm" : "\\ \\ \\ \\ \\ \\ mm";

				var meetingsText = String.Join(", ", slotMeetings);
				var eventsText = String.Join(", ", slotEvents);
				var slotText = $"{meetingsText};{eventsText}".Trim(';');
				dgvCalendar.Rows.Add(slotText);

				dgvCalendar.Rows[i].HeaderCell.Value = slotStartTime.ToString(formatString);
				dgvCalendar.Rows[i].HeaderCell.Style = i % 2 == 0 ? hourStyle : halfAnHourStyle;

				slotStartTime = slotEndTime;
			}
		}
	}
}
