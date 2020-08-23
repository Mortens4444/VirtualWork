using System;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Appointment
{
	public abstract class AppointmentBase : IHaveIdentifier, IHaveTitle
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreationDate { get; set; }

		public abstract DateTime AppointmentDate { get; }

		public DateTime? ExpirationDate { get; set; }

		public int RepetitionValue { get; set; }

		public RepetitionType RepetitionType { get; set; }

		public override string ToString()
		{
			return $"{Title} - {Description}";
		}
	}
}
