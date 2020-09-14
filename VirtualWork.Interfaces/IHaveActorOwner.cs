using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Interfaces
{
	public interface IHaveActorOwner
	{
		int ActorId { get; }

		ActorType ActorType { get; }
	}
}
