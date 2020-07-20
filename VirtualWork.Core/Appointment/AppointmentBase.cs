using System;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Appointment
{
	public class AppointmentBase : IHaveIdentifier, IHaveTitle
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime? ExpirationDate { get; set; }

		public int RepeationValue { get; set; }

		public RepeationType RepeationType { get; set; }
	}
}
