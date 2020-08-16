using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class LogEntry : IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(User))]
		public int? UserId { get; set; }
		public virtual User User { get; set; }

		public DateTime TimeStamp { get; set; }

		public string Message { get; set; }

		public int LogLevel { get; set; }
	}
}