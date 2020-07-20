namespace VirtualWork.Interfaces.Attributes
{
	public class FontColoring : Coloring
	{
		public FontColoring(byte red = 0, byte green = 0, byte blue = 0)
			: base(red, green, blue)
		{
		}

		public FontColoring(byte alpha, byte red, byte green, byte blue)
			: base(alpha, red, green, blue)
		{
		}
	}
}
