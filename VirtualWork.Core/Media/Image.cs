using VirtualWork.Interfaces;

namespace VirtualWork.Core.Media
{
	public class Image : IHaveIdentifier
	{
		public int Id { get; set; }

		public byte[] Content { get; set; }
	}
}