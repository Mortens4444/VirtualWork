using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Persistence.Entities
{
	public class Email : IContactInfo, IHaveIdentifier, IEntityHaveActorOwner
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public int ActorId { get; set; }

		public int ActorType { get; set; }

		[StringLength(100)]
		[Required]
		public string Address { get; set; }
	}
}