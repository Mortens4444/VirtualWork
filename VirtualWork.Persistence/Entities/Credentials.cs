using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Persistence.Entities
{
	public class Credentials : IHaveIdentifier, IHaveName
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		public string Name { get; set; }

		[Required]
		public int ActorId { get; set; }

		public int ActorType { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		public string Group { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string ExtraInformation { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		[SystemSpecificEncryption("d8fé4GH15kd3!5f")]
		public string Username { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfStrings)]
		[SystemSpecificEncryption("43lDF/%gfpsd3ny")]
		public string Password { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string Link { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string AlternativeLink { get; set; }
	}
}
