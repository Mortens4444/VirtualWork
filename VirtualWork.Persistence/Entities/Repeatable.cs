using System;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Persistence.Entities
{
	public class Repeatable
	{
		[UtcDateTime]
		public DateTime? ExpirationDate { get; set; }

		public int RepetitionValue { get; set; }

		public int RepetitionType { get; set; }
	}
}
