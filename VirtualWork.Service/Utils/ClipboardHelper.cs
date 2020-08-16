using System;
using System.Windows.Forms;

namespace VirtualWork.Service.Utils
{
	public static class ClipboardHelper
	{
		public static void SetText(string text)
		{
			try
			{
				Clipboard.SetText(text);
			}
			catch (Exception ex)
			{
				ErrorBoxHelper.Show(ex);
			}
		}
	}
}
