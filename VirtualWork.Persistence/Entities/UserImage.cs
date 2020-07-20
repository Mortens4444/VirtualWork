using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualWork.Persistence.Entities
{
	public class UserImage : Image
	{
		[ForeignKey(nameof(User))]
		[Required]
		public int UserId { get; set; }
		public virtual User User { get; set; }
	}
}