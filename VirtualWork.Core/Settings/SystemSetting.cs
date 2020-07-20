using VirtualWork.Interfaces;

namespace VirtualWork.Core.Settings
{
	public class SystemSetting : IHaveIdentifier
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Value { get; set; }
	}
}
