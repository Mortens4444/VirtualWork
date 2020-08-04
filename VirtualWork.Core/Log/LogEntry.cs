using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Log
{
	public class LogEntry : IHaveIdentifier
	{
		public int Id { get; set; }

		public LogLevel LogLevel { get; set; }

		public string Message { get; set; }

		public IUser User { get; set; }
	}
}