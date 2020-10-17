using System;
using System.Drawing;
using System.Windows.Forms;
using LanguageService;
using VirtualWork.Core.Log;
using VirtualWork.Core.Security;

namespace VirtualWork.WinForms.Extensions
{
	public static class ListViewItemExtensions
	{
		private static readonly Random random = new Random();

		public static ListViewItem ToListViewItem(this LogEntry logEntry, Color backColor)
		{
			var listViewItem = new ListViewItem(logEntry.Id.ToString())
			{
				BackColor = backColor
			};
			listViewItem.SubItems.Add(logEntry.User?.ToString() ?? String.Empty);
			listViewItem.SubItems.Add(Lng.Elem(logEntry.LogLevel.ToString()));
			listViewItem.SubItems.Add(logEntry.Message);
			listViewItem.Tag = logEntry;
			return listViewItem;
		}

		public static ListViewItem ToListViewItem(this Credentials credentials, Color backColor)
		{
			var item = new ListViewItem(credentials.Name)
			{
				Tag = credentials,
				BackColor = backColor
			};
			item.SubItems.Add(credentials.Group);
			item.SubItems.Add(credentials.Username);
			var fakePasswordLength = random.Next(5, 12);
			var stars = new char[fakePasswordLength];
			for (int j = 0; j < stars.Length; j++)
			{
				stars[j] = '*';
			}
			item.SubItems.Add(new String(stars));
			item.SubItems.Add(credentials.Link);
			item.SubItems.Add(credentials.AlternativeLink);
			item.SubItems.Add(credentials.ExtraInformation);
			return item;
		}

		public static ListViewItem ToListViewItem(this Permission permission, Color backColor)
		{
			return new ListViewItem(Lng.Elem(permission.Description))
			{
				Tag = permission,
				BackColor = backColor
			};
		}
	}
}
