using System.Windows.Forms;

namespace VirtualWork.WinForms.Controls
{
	public class DoubleBufferedPanel : Panel
	{
		public DoubleBufferedPanel()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			UpdateStyles();
		}
	}
}
