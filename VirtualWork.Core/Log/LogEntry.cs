using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Log
{
	public class LogEntry : IHaveIdentifier
	{
		public int Id { get; set; }

		public LogLevel LogLevel { get; set; }

		public string Message { get; set; }

		public User User { get; set; }
	}
}