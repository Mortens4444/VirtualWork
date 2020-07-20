using VirtualWork.Core.Actors;
using VirtualWork.Interfaces;

namespace VirtualWork.Core.Settings
{
	public class UserSetting : IHaveIdentifier
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Value { get; set; }

		public User User { get; set; }
	}
}
