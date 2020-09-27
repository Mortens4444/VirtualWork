using System;
using System.Collections.Generic;
using VirtualWork.Core.Actors;

namespace VirtualWork.Core.Appointment
{
	public class Meeting : AppointmentBase
	{
		public User Owner { get; set; }

		public DateTime MeetingDate { get; set; }

		public DateTime MeetingEndDate { get; set; }

		public virtual ICollection<User> Followers { get; set; }

		public string MeetingPoint { get; set; }

		public override DateTime AppointmentDate => MeetingDate;

		public override DateTime AppointmentEndDate => MeetingEndDate;
	}
}
