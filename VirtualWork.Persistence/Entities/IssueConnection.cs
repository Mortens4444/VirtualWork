using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
    public class IssueConnection : IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(Issue1))]
		[Required]
		public int Issue1Id { get; set; }
		public virtual Issue Issue1 { get; set; }

		[ForeignKey(nameof(Issue2))]
		[Required]
		public int Issue2Id { get; set; }
		public virtual Issue Issue2 { get; set; }

		public int ConnectionType { get; set; }
    }
}
