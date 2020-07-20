using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class Resource : IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(User))]
		[Required]
		public int UserId { get; set; }
		public virtual User User { get; set; }

		public int ResourceType { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string Key { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string OtherInformation { get; set; }
	}
}
