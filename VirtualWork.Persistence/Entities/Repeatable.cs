using System;

namespace VirtualWork.Persistence.Entities
{
	public class Repeatable
	{
		public DateTime? ExpirationDate { get; set; }

		public int RepetitionValue { get; set; }

		public int RepetitionType { get; set; }
	}
}
