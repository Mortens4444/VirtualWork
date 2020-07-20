using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Persistence.Entities
{
	public class TelephoneNumber : IContactInfo, IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(User))]
		public int UserId { get; set; }
		public virtual User User { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		public string Number { get; set; }
	}
}