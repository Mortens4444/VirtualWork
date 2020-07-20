namespace VirtualWork.Interfaces.Attributes
{
	public class BackgroundColoring : Coloring
	{
		public BackgroundColoring(byte red = 0, byte green = 0, byte blue = 0)
			: base(red, green, blue)
		{
		}

		public BackgroundColoring(byte alpha, byte red, byte green, byte blue)
			: base(alpha, red, green, blue)
		{
		}
	}
}
