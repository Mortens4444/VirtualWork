using System;
using LanguageService;
using MessageBoxes;

namespace VirtualWork.Service.Utils
{
	public static class ErrorBoxHelper
	{
		public static void Show(Exception ex)
		{
			ErrorBox.Show(Lng.Elem("General"), ex.Message);
		}
	}
}
