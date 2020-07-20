using System.IO;
using System.Windows.Forms;

namespace VirtualWork.WinForms.Extensions
{
	public static class ListViewExtensions
	{
		public static void FillItems(this ListView listView, ListViewItem[] listViewItems, string selected = null)
		{
			listView.Items.Clear();
			listView.Items.AddRange(listViewItems);
			if (selected != null)
			{
				foreach (ListViewItem item in listView.Items)
				{
					item.Selected = item.Text == Path.GetFileName(selected);
				}
			}
		}
	}
}
