using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Interfaces
{
	public interface IResource
	{
		ResourceType ResourceType { get; }

		string Key { get; }
	}
}
