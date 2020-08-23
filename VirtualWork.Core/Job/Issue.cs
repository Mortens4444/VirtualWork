using System;
using System.Collections.Generic;
using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Job;

namespace VirtualWork.Core.Job
{
	public class Issue : IIssue, IHaveIdentifier, IHaveTitle
	{
		public int Id { get; set; }

		public User Creator { get; set; }

		public string Description { get; set; }

		public string Title { get; set; }

		public bool IsVerified { get; set; }

		public bool IsBlocked { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime DueDate { get; set; }

		public Issue Parent { get; set; }

		public HashSet<INotifiable> Followers { get; set; }

		public TimeSpan Interval { get; set; }

		public HashSet<Issue> Issues { get; set; }

		public IssueType IssueType { get; set; }

		public IssueState IssueState { get; set; }

		public User Owner { get; set; }

		public Priority Priority { get; set; }

		public DateTime? ExpirationDate { get; set; }

		public int RepetitionValue { get; set; }

		public RepetitionType RepetitionType { get; set; }

		public override string ToString()
		{
			return Title;
		}
	}
}