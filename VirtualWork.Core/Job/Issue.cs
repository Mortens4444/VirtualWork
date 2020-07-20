using System;
using System.Collections.Generic;
using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Job
{
	public class Issue : IHaveIdentifier, IHaveTitle
	{
		public int Id { get; set; }

		public User Creator { get; set; }

		public string Description { get; set; }

		public string Title { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime DueDate { get; set; }

		public Issue Epic { get; set; }

		public HashSet<INotifiable> Followers { get; set; }

		public TimeSpan Interval { get; set; }

		public HashSet<Issue> Issues { get; set; }

		public IssueType IssueType { get; set; }

		public IssueState IssueState { get; set; }

		public User Owner { get; set; }

		public Priority Priority { get; set; }

		public DateTime? ExpirationDate { get; set; }

		public int RepeationValue { get; set; }

		public RepeationType RepeationType { get; set; }

		/// <summary>
		/// @param notifiable
		/// </summary>
		public void Assign(INotifiable notifiable)
		{
			throw new NotImplementedException();
		}
	}
}