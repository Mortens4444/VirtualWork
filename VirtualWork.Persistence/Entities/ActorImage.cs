using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualWork.Persistence.Entities
{
	public class ActorImage : Image
	{
		[Required]
		public int ActorId { get; set; }

		public int ActorType { get; set; }
	}
}