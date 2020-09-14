using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Infrastructure
{
	public class Resource : IHaveIdentifier, IHaveActorOwner
	{
		public int Id { get; set; }

		public ResourceType ResourceType { get; set; }

		public string Key { get; set; }

		public string OtherInformation { get; set; }

		public Actor Actor { get; set; }

		public int ActorId { get => Actor.Id; }

		public ActorType ActorType { get; set; }
	}
}
