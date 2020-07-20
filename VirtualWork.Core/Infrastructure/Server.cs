using System.Collections.Generic;
using VirtualWork.Interfaces;

namespace VirtualWork.Core.Infrastructure
{
	public class Server : IHaveIdentifier, IHaveName
	{
		public int Id { get; set; }

		public string IpAddress { get; set; }

		public string MacAddress { get; set; }

		public string Name { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public IEnumerable<Camera> Cameras { get; set; }
	}
}
