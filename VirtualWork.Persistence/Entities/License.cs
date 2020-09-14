using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Persistence.Entities
{
	public class License : IHaveIdentifier, IEntityHaveActorOwner
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public int ActorId { get; set; }

		public int ActorType { get; set; }

		public string Code { get; set; }

		public string Description { get; set; }

		public string Name { get; set; }

		[UtcDateTime]
		public DateTime OrderDate { get; set; }

		[UtcDateTime]
		public DateTime? RenewalDate { get; set; }
	}
}
