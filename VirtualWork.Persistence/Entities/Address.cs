using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Persistence.Entities
{
	public class Address : IContactInfo, IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(User))]
		[Required]
		public int UserId { get; set; }
		public virtual User User { get; set; }

		[StringLength(100)]
		public string City { get; set; }

		[StringLength(100)]
		public string Country { get; set; }

		[StringLength(10)]
		public string Number { get; set; }

		[StringLength(100)]
		public string PublicArea { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string FullAddress { get; set; }

		public int PublicAreaKind { get; set; }
	}
}