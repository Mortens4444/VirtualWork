using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LanguageService;
using VirtualWork.Core.Utils;
using VirtualWork.Interfaces;

namespace VirtualWork.WinForms.Extensions
{
	public static class ComboBoxExtensions
	{
		public static void FillWithEnum<TItems>(this ComboBox comboBox, int selectedIndex = 0)
		{
			var items = Enum.GetValues(typeof(TItems));
			foreach (Enum item in items)
			{
				comboBox.Items.Add(Lng.Elem(item.GetDescription()));
			}			
			comboBox.SelectedIndex = selectedIndex;
		}

		public static void AddMatchingItems<TDtoType>(this ComboBox comboBox, IEnumerable<TDtoType> items)
		{
			var selectionStart = comboBox.SelectionStart;
			comboBox.Items.Clear();
			foreach (var item in items)
			{
				comboBox.Items.Add(item);
			}
			comboBox.SelectionStart = selectionStart;
		}
	}
}
