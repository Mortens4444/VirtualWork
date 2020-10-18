using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class Resource : IHaveIdentifier, IEntityHaveActorOwner
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public int ActorId { get; set; }

		public int ActorType { get; set; }

		public int ResourceType { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string Key { get; set; }

		public string OtherInformation { get; set; }
	}
}
