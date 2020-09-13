using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Persistence.Entities
{
	[Table("IssueHistoryEntries")]
	public class IssueHistory : IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(Issue))]
		public int IssueId { get; set; }
		public virtual Issue Issue { get; set; }

		[ForeignKey(nameof(ModifierUser))]
		public int ModifierUserId { get; set; }
		public virtual User ModifierUser { get; set; }

		[UtcDateTime]
		public DateTime ModifyDate { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		public string ModifyInfo { get; set; }
	}
}