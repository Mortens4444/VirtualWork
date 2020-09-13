using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Persistence.Entities
{
	public class Event : Repeatable, IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(Creator))]
		[Required]
		public int CreatorId { get; set; }
		public virtual User Creator { get; set; }
		
		[StringLength(100)]
		[Required]
		public string Title { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string Description { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string EventLocation { get; set; }

		[UtcDateTime]
		public DateTime EventDate { get; set; }

		[StringLength(PersistenceConstants.MaxLengthOfLongStrings)]
		public string StartApplication { get; set; }
	}
}