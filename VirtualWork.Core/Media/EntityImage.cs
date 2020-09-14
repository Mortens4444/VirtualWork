using System.Drawing;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Media
{
	public class EntityImage : IHaveIdentifier, IHaveEntityOwner
	{
		public int Id { get; set; }

		public Image Image { get; set; }

		public IHaveIdentifier Entity { get; set; }

		public int EntityId { get => Entity.Id; }

		public EntityType EntityType { get; set; }

		public string Description { get; set; }
	}
}