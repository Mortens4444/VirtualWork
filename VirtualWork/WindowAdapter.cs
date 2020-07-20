using System.Windows;
using VirtualWork.Interfaces.Windows;

namespace VirtualWork.Service.Windows
{
	class WindowAdapter : Window, IWindow
	{
		bool IWindow.ShowDialog()
		{
			var result = ShowDialog();
			return result.HasValue && result.Value;
		}
	}
}
