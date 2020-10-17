﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VirtualWork.Core.Appointment;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Enums;
using EventRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Event, VirtualWork.Persistence.Entities.Event>;
using MeetingRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Appointment.Meeting, VirtualWork.Persistence.Entities.Meeting>;

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
			var meetings = meetingRepository.GetAll(meeting => meeting.MeetingDate.IsRepeatedOnDate(date, (RepetitionType)meeting.RepetitionType, meeting.RepetitionValue, meeting.ExpirationDate));
			var events = eventRepository.GetAll(myEvent => myEvent.EventDate.IsRepeatedOnDate(date, (RepetitionType)myEvent.RepetitionType, myEvent.RepetitionValue, myEvent.ExpirationDate));

			var slotStartTime = new TimeSpan(0, 0, 0);
			for (int i = 0; i < 48; i++)
			{
				var slotEndTime = slotStartTime.Add(HalfAnHour);
				
				var slotMeetings = meetings
					.Where(meeting => DateTimeExtensions.AreDatesTimeBetweenTimeSpans(meeting.MeetingDate, meeting.MeetingEndDate, slotStartTime, slotEndTime))
					.Select(meeting => meeting.Title);
				var slotEvents = events
					.Where(myEvent => DateTimeExtensions.AreDatesTimeBetweenTimeSpans(myEvent.EventDate, myEvent.EventEndDate, slotStartTime, slotEndTime))
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

		public void SetBoldDates(MonthCalendar monthCalendar)
		{
			IEnumerable<AppointmentBase> meetings = meetingRepository.GetAll();
			IEnumerable<AppointmentBase> events = eventRepository.GetAll();
			var appointments = meetings.Concat(events).ToList();

			foreach (var appointment in appointments)
			{
				var futureOccurances = appointment.GetNextOccuranceDates();
				foreach (var futureOccurance in futureOccurances)
				{
					monthCalendar.AddBoldedDate(futureOccurance);
				}
			}
		}
	}
}
