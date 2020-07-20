using VirtualWork.Interfaces;

namespace VirtualWork.Core.Infrastructure
{
	public class Camera : IHaveIdentifier, IHaveName
	{
		public int Id { get; set; }

		public int? ServerId { get; set; }

		public string Uri { get; set; }

		public string Name { get; set; }

		public string Desription { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }
	}
}
