using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;

namespace VirtualWork.Persistence.Entities
{
	public class Camera : IHaveIdentifier, IHaveName
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey(nameof(Server))]
		public int? ServerId { get; set; }
		public virtual Server Server { get; set; }

		public string Uri { get; set; }

		public string Name { get; set; }

		public string Desription { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }
	}
}
