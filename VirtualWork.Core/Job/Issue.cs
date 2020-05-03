using System;
using System.Collections.Generic;
using VirtualWork.Core.Actors;
using VirtualWork.Core.Enums;
using VirtualWork.Interfaces.Actors;

namespace VirtualWork.Core.Job
{
	public class Issue
	{
		public int Id { get; set; }

		public HashSet<User> Contacts { get; set; }

		public User Creator { get; set; }

		public string Description { get; set; }

		public DateTime DueDate { get; set; }

		public int EpicId { get; set; }

		public HashSet<INotifiable> Followers { get; set; }

		public TimeSpan Interval { get; set; }

		public HashSet<Issue> Issues { get; set; }

		public IssueType IssueType { get; set; }

		public IssueState IssueState { get; set; }

		public User Owner { get; set; }

		public Priority Priority { get; set; }

		public SchedulleInfo SchedulleInfo { get; set; }

		/// <summary>
		/// @param notifiable
		/// </summary>
		public void Assign(INotifiable notifiable)
		{
			throw new NotImplementedException();
		}
	}
}