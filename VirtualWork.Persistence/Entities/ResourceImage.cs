using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualWork.Persistence.Entities
{
	public class ResourceImage : Image
	{
		[ForeignKey(nameof(Resource))]
		[Required]
		public int ResourceId { get; set; }
		public virtual Resource Resource { get; set; }
	}
}