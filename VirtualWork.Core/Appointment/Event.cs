using System;
using System.Collections.Generic;
using VirtualWork.Core.Actors;
using VirtualWork.Interfaces.Actors;

namespace VirtualWork.Core.Appointment
{
	public class Event : AppointmentBase
	{
		public User Creator { get; set; }

		public DateTime EventDate { get; set; }

		public HashSet<INotifiable> Partners { get; set; }

		public string ApplicationToStart { get; set; }

		public string Arguments { get; set; }

		public string EventLocation { get; set; }

		public override DateTime AppointmentDate => EventDate;
	}
}
