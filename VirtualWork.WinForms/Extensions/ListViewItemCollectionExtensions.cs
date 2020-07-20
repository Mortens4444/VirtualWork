using System.Collections.Generic;
using System.Windows.Forms;
using VirtualWork.Core.Security;
using static System.Windows.Forms.ListView;

namespace VirtualWork.WinForms.Extensions
{
	public static class ListViewItemCollectionExtensions
	{
		public static IList<Permission> ToPermissions(this ListViewItemCollection listViewItemCollection)
		{
			var result = new List<Permission>();
			foreach (ListViewItem listViewItem in listViewItemCollection)
			{
				result.Add((Permission)listViewItem.Tag);
			}
			return result;
		}
	}
}
