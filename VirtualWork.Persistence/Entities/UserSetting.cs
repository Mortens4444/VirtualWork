using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualWork.Persistence.Entities
{
	public class UserSetting : Setting
	{
		[ForeignKey(nameof(User))]
		[Required]
		public int UserId { get; set; }
		public virtual User User { get; set; }
    }
}
