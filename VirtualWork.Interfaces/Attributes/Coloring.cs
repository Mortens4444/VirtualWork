using System;

namespace VirtualWork.Interfaces.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public abstract class Coloring : Attribute
	{
		public byte Alpha { get; }

		public byte Red { get; }

		public byte Green { get; }

		public byte Blue { get; }

		public Coloring(byte red, byte green, byte blue)
			: this(255, red, green, blue)
		{
		}

		public Coloring(byte alpha, byte red, byte green, byte blue)
		{
			Alpha = alpha;
			Red = red;
			Green = green;
			Blue = blue;
		}
	}
}
