using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VirtualWork.Core.Other;
using VirtualWork.Interfaces.Enums;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms.Controls
{
	public class RichTextBoxWithHighlight : RichTextBox
	{
		[DllImport("User32.dll", SetLastError = true)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int[] lParam);

		private const int NotFound = -1;
		private const int EmSetTabStops = 203;
		private const string LineFeedString = "\n";
		private const char CarriageReturn = '\r';
		private const char LineFeed = '\n';

		private readonly Dictionary<ColoringMode, Func<Font, IEnumerable<Coloring>>>
			coloringModes = new Dictionary<ColoringMode, Func<Font, IEnumerable<Coloring>>>
			{
				{ ColoringMode.CppCli, ColoringProvider.GetCppCliColoring },
				{ ColoringMode.CSharp, ColoringProvider.GetCSharpColoring },
				{ ColoringMode.Java, ColoringProvider.GetJavaColoring },
				{ ColoringMode.ObjectPascal, ColoringProvider.GetObjectPascalColoring },
				{ ColoringMode.VisualBasic, ColoringProvider.GetVisualBasicColoring },
				{ ColoringMode.VisualCpp, ColoringProvider.GetVisualCppColoring },
			};

		private int scrollTo;
		private int position;
		private int length;

		public RichTextBoxWithHighlight()
		{
			DetectUrls = false;
			Dock = DockStyle.Fill;
			AcceptsTab = true;
			SetTabSize();
		}

		[Description("Mode of the coloring.")]
		public ColoringMode ColoringMode { get; set; } = ColoringMode.NoColoring;

		private void SetTabSize()
		{
			using (Graphics graphics = CreateGraphics())
			{
				SendMessage(Handle, 203U, 1, new int[1] { graphics.MeasureString("M", Font).ToSize().Width });
			}
		}

		public void BeginUpdate() => SendMessage(Handle, 11U, 0, new int[0]);

		public void EndUpdate()
		{
			SendMessage(Handle, 11U, 1, new int[0]);
			Invalidate();
		}

		public void StartUpdate(ref int scrollto, ref int pos, ref int len)
		{
			BeginUpdate();
			scrollto = GetCharIndexFromPosition(new Point(1, 1));
			pos = SelectionStart;
			len = SelectionLength;
		}

		public void StopUpdate(int scrollto, int pos, int len)
		{
			SelectionStart = scrollto;
			ScrollToCaret();
			SelectionStart = pos;
			SelectionLength = len;
			EndUpdate();
		}

		private void SetSelectionBackColor(int lineIndex, Color color)
		{
			int length = 0;
			int charIndexFromLine = GetFirstCharIndexFromLine(lineIndex);
			if (charIndexFromLine <= -1)
			{
				return;
			}
			
			while (Text[charIndexFromLine] != CarriageReturn && Text[charIndexFromLine] != LineFeed)
			{
				length++;
				charIndexFromLine++;
				if (charIndexFromLine == Text.Length)
				{
					break;
				}
			}
			if (length <= 0)
			{
				return;
			}
			Select(charIndexFromLine - length, length);
			SelectionBackColor = color;
		}

		protected override void OnTextChanged(EventArgs e)
		{
			StartUpdate(ref scrollTo, ref position, ref length);
			if (ColoringMode != ColoringMode.NoColoring)
			{
				Coloring();
			}
			base.OnTextChanged(e);
			StopUpdate(scrollTo, position, length);
		}

		public void ClearColoring()
		{
			SelectAll();
			SelectionFont = Font;
			SelectionColor = ForeColor;
		}

		public void ClearBackgroundColoring()
		{
			Select(0, Text.Length);
			SelectionBackColor = BackColor;
		}

		private void Coloring()
		{
			ClearColoring();

			var colorings = coloringModes.ContainsKey(ColoringMode) ? coloringModes[ColoringMode](Font) : new List<Coloring>();
			foreach (var coloring in colorings)
			{
				ColorWithArray(coloring);
			}

			var regularFont = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
			var italicFont = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);

			ColorWithString("\"", "\"", regularFont, Color.DarkRed);
			if (ColoringMode != ColoringMode.VisualBasic)
			{
				ColorWithString("'", "'", regularFont, Color.SteelBlue);
			}
			switch (ColoringMode)
			{
				case ColoringMode.ObjectPascal:
					ColorWithString("{", "}", italicFont, Color.Green);
					break;
				case ColoringMode.VisualBasic:
					ColorWithString("'", null, italicFont, Color.Green);
					break;
				default:
					ColorWithString("//", null, italicFont, Color.Green);
					ColorWithString("/*", "*/", italicFont, Color.Green);
					break;
			}
		}

		private void ColorWithArray(Coloring coloring)
		{
			var options = coloring.MatchCase ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;
			if (coloring.Keywords != null)
			{
				foreach (var keyword in coloring.Keywords)
				{
					int start = -1;
					while ((start = Find(keyword, start + 1, options)) != -1)
					{
						if ((start == 0 || start > 0 && !char.IsLetterOrDigit(Text[start - 1])) && (Text.Length == start + keyword.Length || Text.Length > start + keyword.Length && !char.IsLetterOrDigit(Text[start + keyword.Length])))
						{
							Coloring(start, keyword.Length, coloring.Font, coloring.Color);
							if (coloring.SecondaryColor != Color.Transparent)
							{
								int num = Text.IndexOf(LineFeedString, start + keyword.Length);
								if (num > -1)
									Select(start + keyword.Length, num - start - keyword.Length);
								else
									Select(start + keyword.Length, Text.Length - start - keyword.Length);
								SelectionFont = coloring.Font;
								SelectionColor = coloring.SecondaryColor;
							}
						}
					}
				}
			}
		}

		public void Coloring(int startIndex, int length, Font font, Color foreColor)
		{
			Coloring(startIndex, length, font, foreColor, BackColor);
		}

		public void Coloring(int startIndex, int length, Font font, Color foreColor, Color backColor)
		{
			Select(startIndex, length);
			SelectionFont = font;
			SelectionColor = foreColor;
			SelectionBackColor = backColor;
		}

		private void ColorWithString(string beginingPattern, string endingPattern, Font font, Color color)
		{
			int num = -1;
			int start;
			do
			{
				int startIndex = num + 1;
				start = Text.IndexOf(beginingPattern, startIndex);
				if (start != -1)
				{
					num = endingPattern == null ? Text.IndexOf(LineFeedString, start + 1) : Text.IndexOf(endingPattern, start + 1);
					if (num == -1)
					{
						num = Text.Length;
					}

					var endingPatternLength = endingPattern?.Length ?? 0;
					Coloring(start, num - start + endingPatternLength, font, color);
				}
			}
			while (start != -1 && num + 1 < Text.Length);
		}
	}

}
