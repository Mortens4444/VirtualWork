using VirtualWork.Interfaces;

namespace VirtualWork.Core.Security
{
	public class Permission : IHaveIdentifier
	{
		public int Id { get; set; }

		public string Description { get; set; }

		public string Name { get; set; }
	}
}