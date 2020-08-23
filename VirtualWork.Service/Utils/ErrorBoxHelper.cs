using System;
using LanguageService;
using MessageBoxes;
using VirtualWork.Interfaces.Log;

namespace VirtualWork.Service.Utils
{
	public class ErrorBoxHelper
	{
		private readonly ILogger logger;

		public ErrorBoxHelper(ILogger logger)
		{
			this.logger = logger;
		}

		public void Show(Exception ex)
		{
			logger.Error(ex);
			ErrorBox.Show(Lng.Elem("General"), ex.Message);
		}
	}
}
