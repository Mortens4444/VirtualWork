using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class Comment : IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(Issue))]
		[Required]
		public int IssueId { get; set; }
		public virtual Issue Issue { get; set; }

		[ForeignKey(nameof(User))]
		[Required]
		public int UserId { get; set; }
		public virtual User User { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		[Required]
		public string Text { get; set; }
	}
}
