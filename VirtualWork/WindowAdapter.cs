using System;
using System.Windows;
using VirtualWork.Interfaces.Windows;

namespace VirtualWork.Service.Windows
{
	class WindowAdapter : Window, IWindow
	{
		public bool ShowDialog(object obj)
		{
			throw new NotImplementedException();
		}

		bool IWindow.ShowDialog()
		{
			var result = ShowDialog();
			return result.HasValue && result.Value;
		}
	}
}
