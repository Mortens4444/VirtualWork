using VirtualWork.Core.Enums;

namespace VirtualWork.Core.Actors
{
	public class User : Actor
	{
		public bool IsActive { get; set; }

		public UserType UserType { get; set; }
	}
}