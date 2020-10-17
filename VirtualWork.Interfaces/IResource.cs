using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Interfaces
{
	public interface IResource : ICanBeOrdered
	{
		ResourceType ResourceType { get; }

		string Key { get; }
	}
}
