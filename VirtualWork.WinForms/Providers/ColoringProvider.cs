using System.Collections.Generic;
using System.Drawing;
using VirtualWork.Core.Keywords;
using VirtualWork.Core.Other;

namespace VirtualWork.WinForms.Providers
{
	public static class ColoringProvider
	{
		public static List<Coloring> GetCppCliColoring(Font font)
		{
			return new List<Coloring>
				{
					new Coloring(CppCli.Keywords, font, Color.Blue),
					new Coloring(CompilerDirectives.Keywords, font, Color.Gray, Color.DarkRed),
					new Coloring(ComplexDotNetTypes.Keywords, font, Color.DarkBlue),
					new Coloring(DotNetNamespace.Keywords, font, Color.DarkBlue),
					new Coloring(WinApi.Keywords, font, Color.DarkBlue),
					new Coloring(FormControls.Keywords, font, Color.Green)
				};
		}

		public static List<Coloring> GetCSharpColoring(Font font)
		{
			return new List<Coloring>
				{
					new Coloring(CSharp.Keywords, font, Color.Blue),
					new Coloring(CompilerDirectives.Keywords, font, Color.Gray, Color.DarkRed),
					new Coloring(ComplexDotNetTypes.Keywords, font, Color.DarkBlue),
					new Coloring(DotNetNamespace.Keywords, font, Color.DarkBlue),
					new Coloring(WinApi.Keywords, font, Color.DarkBlue),
					new Coloring(FormControls.Keywords, font, Color.Green)
				};
		}

		public static List<Coloring> GetJavaColoring(Font font)
		{
			return new List<Coloring>
				{
					new Coloring(Java.Keywords, font, Color.Blue)
				};
		}

		public static List<Coloring> GetObjectPascalColoring(Font font)
		{
			return new List<Coloring>
				{
					new Coloring(ObjectPascal.Keywords, font, Color.Blue, false)
				};
		}

		public static List<Coloring> GetVisualBasicColoring(Font font)
		{
			return new List<Coloring>
				{
					new Coloring(VisualBasic.Keywords, font, Color.Blue, false),
					new Coloring(CompilerDirectives.Keywords, font, Color.Gray, Color.DarkRed, false),
					new Coloring(ComplexDotNetTypes.Keywords, font, Color.DarkBlue, false),
					new Coloring(DotNetNamespace.Keywords, font, Color.DarkBlue, false),
					new Coloring(WinApi.Keywords, font, Color.DarkBlue, false),
					new Coloring(FormControls.Keywords, font, Color.Green, false)
				};
		}

		public static List<Coloring> GetVisualCppColoring(Font font)
		{
			return new List<Coloring>
				{
					new Coloring(Cpp.Keywords, font, Color.Blue),
					new Coloring(CompilerDirectives.Keywords, font, Color.DarkBlue, Color.DarkRed),
					new Coloring(DotNetNamespace.Keywords, font, Color.Green)
				};
		}
	}
}
