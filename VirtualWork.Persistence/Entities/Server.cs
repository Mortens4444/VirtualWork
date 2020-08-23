using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Attributes;

namespace VirtualWork.Persistence.Entities
{
	public class Server : IHaveIdentifier, IHaveName
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string IpAddress { get; set; }

		public string MacAddress { get; set; }

		public string Name { get; set; }

		[SystemSpecificEncryption("f[6/95*e2jDeTgb")]
		public string Username { get; set; }

		[SystemSpecificEncryption("j7$dE4.tRd3X#")]
		public string Password { get; set; }

		public virtual ICollection<Camera> Cameras { get; set; }
	}
}
