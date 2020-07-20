using VirtualWork.Core.Actors;
using VirtualWork.Core.Job;
using VirtualWork.Interfaces;

namespace VirtualWork.Core.Other
{
	public class Comment : IHaveIdentifier
	{
		public int Id { get; set; }

		public Issue Issue { get; set; }

		public User User { get; set; }

		public string Text { get; set; }
	}
}
