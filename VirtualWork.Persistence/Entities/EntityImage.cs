using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class EntityImage : IHaveIdentifier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public byte[] ImageBytes { get; set; }

		[Required]
		public int EntityId { get; set; }

		public int EntityType { get; set; }

		public string Description { get; set; }
	}
}