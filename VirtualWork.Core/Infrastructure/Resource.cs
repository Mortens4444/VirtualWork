using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Infrastructure
{
	public class Resource : IHaveIdentifier
	{
		public int Id { get; set; }

		public ResourceType ResourceType { get; set; }

		public string Key { get; set; }

		public string OtherInformation { get; set; }

		public User User { get; set; }
	}
}
