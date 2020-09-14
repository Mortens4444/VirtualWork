using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Persistence.Entities
{
	public class TelephoneNumber : IContactInfo, IHaveIdentifier, IEntityHaveActorOwner
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public int ActorId { get; set; }

		public int ActorType { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		public string Number { get; set; }
	}
}