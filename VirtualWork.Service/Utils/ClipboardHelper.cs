using System;
using System.Windows.Forms;

namespace VirtualWork.Service.Utils
{
	public class ClipboardHelper
	{
		private readonly ErrorBoxHelper errorBoxHelper;

		public ClipboardHelper(ErrorBoxHelper errorBoxHelper)
		{
			this.errorBoxHelper = errorBoxHelper;
		}

		public void SetText(string text)
		{
			try
			{
				Clipboard.SetText(text);
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}
	}
}
