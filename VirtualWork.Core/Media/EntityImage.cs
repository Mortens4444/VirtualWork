using System.Drawing;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Media
{
	public class EntityImage : IHaveIdentifier
	{
		public int Id { get; set; }

		public Image Image { get; set; }

		public IHaveIdentifier Entity { get; set; }

		public EntityType EntityType { get; set; }
	}
}