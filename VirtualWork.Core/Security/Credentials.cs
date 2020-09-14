using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Security
{
	public class Credentials : IHaveIdentifier, IHaveName, IHaveActorOwner
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Group { get; set; }

		public string ExtraInformation { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public string Link { get; set; }

		public string AlternativeLink { get; set; }

		public int ActorId { get; set; }

		public ActorType ActorType { get; set; }
	}
}
