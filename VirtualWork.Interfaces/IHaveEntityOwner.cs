using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Interfaces
{
	public interface IHaveEntityOwner
	{
		int EntityId { get; }

		EntityType EntityType { get; }
	}
}
