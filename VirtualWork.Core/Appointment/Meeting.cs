using System;
using System.Collections.Generic;
using VirtualWork.Core.Actors;

namespace VirtualWork.Core.Appointment
{
	public class Meeting : AppointmentBase
	{
		public User Owner { get; set; }

		public DateTime MeetingDate { get; set; }

		public virtual ICollection<User> Followers { get; set; }
	}
}
