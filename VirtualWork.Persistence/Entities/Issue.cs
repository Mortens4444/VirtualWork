using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Persistence.Entities
{
	public class Issue : Repeatable, IHaveIdentifier, IHaveTitle
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(Parent))]
		public int? ParentId { get; set; }
		public virtual Issue Parent { get; set; }

		[ForeignKey(nameof(Creator))]
		[Required]
		public int CreatorId { get; set; }
		public virtual User Creator { get; set; }

		[ForeignKey(nameof(Owner))]
		public int? OwnerId { get; set; }
		public virtual User Owner { get; set; }

		public string Description { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		[Required]
		public string Title { get; set; }

		[UtcDateTime]
		public DateTime CreationDate { get; set; }

		[UtcDateTime]
		public DateTime DueDate { get; set; }

		public TimeSpan Interval { get; set; }

		public bool IsVerified { get; set; }

		public bool IsBlocked { get; set; }

		public int IssueType { get; set; }

		public int IssueState { get; set; }

		public int Priority { get; set; }

		public virtual ICollection<User> Followers { get; set; }

		public virtual ICollection<IssueConnection> IssueConnections { get; set; }

		public virtual ICollection<IssueHistory> IssueHistoryEntries { get; set; }

		public virtual ICollection<Comment> Comments { get; set; }

		public override string ToString()
		{
			return $"{Id} - {Title}";
		}
	}
}