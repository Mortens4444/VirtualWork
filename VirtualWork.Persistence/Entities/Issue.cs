using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class Issue : Repeatable, IHaveIdentifier, IHaveTitle
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(Epic))]
		public int? EpicId { get; set; }
		public virtual Issue Epic { get; set; }

		[ForeignKey(nameof(Creator))]
		[Required]
		public int CreatorId { get; set; }
		public virtual User Creator { get; set; }

		[ForeignKey(nameof(Owner))]
		public int? OwnerId { get; set; }
		public virtual User Owner { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string Description { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		[Required]
		public string Title { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime DueDate { get; set; }

		public TimeSpan Interval { get; set; }

		public virtual ICollection<User> Followers { get; set; }

		public virtual ICollection<IssueConnection> IssueConnections { get; set; }

		public virtual ICollection<IssueHistory> IssueHistoryEntries { get; set; }

		public virtual ICollection<Comment> Comments { get; set; }

		public int IssueType { get; set; }

		public int IssueState { get; set; }

		public int Priority { get; set; }

		public bool IsMatchingPattern(string pattern)
		{
			return Title.ContainsIgnoreCase(pattern);
		}

		public override string ToString()
		{
			return Title;
		}
	}
}