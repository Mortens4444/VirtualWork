using VirtualWork.Core.Actors;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Media
{
	public class ActorImage : Image
	{
		public Actor Actor { get; set; }

		public ActorType ActorType { get; set; }
	}
}