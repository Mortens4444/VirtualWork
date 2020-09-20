using System.Collections.Generic;
using System.Drawing;

namespace VirtualWork.Core.Other
{
	public class Coloring
	{
		public Font Font { get; }

		public Color Color { get; }

		public Color SecondaryColor { get; }

		public IEnumerable<string> Keywords { get; }

		public bool MatchCase { get; }

		public Coloring(IEnumerable<string> keywords, Font font, Color color, bool matchCase = true)
			: this(keywords, font, color, Color.Transparent, matchCase)
		{
		}

		public Coloring(IEnumerable<string> keywords, Font font, Color color, Color secondaryColor, bool matchCase = true)
		{
			Font = new Font(font.FontFamily, font.Size, FontStyle.Bold);
			Color = color;
			SecondaryColor = secondaryColor;
			Keywords = keywords;
			MatchCase = matchCase;
		}
	}
}
