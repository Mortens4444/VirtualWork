using System;

namespace VirtualWork.Core.Job
{
	public class IssueHistory
	{
		public int Id { get; set; }

		public int IssueId { get; set; }

		public int ModifierUserId { get; set; }

		public DateTime ModifyDate { get; set; }

		public string ModifyInfo { get; set; }
	}
}