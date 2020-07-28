using System.Windows.Forms;

namespace VirtualWork.WinForms.Extensions
{
	public static class ToolStripMenuItemExtensions
	{
		public static void SetEnabled(this ToolStripMenuItem toolStripMenuItem, bool enabled)
		{
			toolStripMenuItem.Enabled = enabled;
			toolStripMenuItem.Visible = enabled;
		}
	}
}
