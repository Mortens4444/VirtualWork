using System;
using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;

namespace VirtualWork.Core.Job
{
	public class IssueHistory : IHaveIdentifier
	{
		public int Id { get; set; }

		public Issue Issue { get; set; }

		public User ModifierUser { get; set; }

		public DateTime ModifyDate { get; set; }

		public string ModifyInfo { get; set; }
	}
}