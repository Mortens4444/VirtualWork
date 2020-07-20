using System;

namespace VirtualWork.Persistence.Entities
{
	public class Repeatable
	{
		public DateTime? ExpirationDate { get; set; }

		public int RepeationValue { get; set; }

		public int RepeationType { get; set; }
	}
}
