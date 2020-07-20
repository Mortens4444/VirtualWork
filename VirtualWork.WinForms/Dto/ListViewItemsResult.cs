using System.Windows.Forms;

namespace VirtualWork.WinForms.Dto
{
	public class ListViewItemsResult
	{
		public bool Success { get; set; }

		public ListViewItem[] Items { get; set; }
	}
}
