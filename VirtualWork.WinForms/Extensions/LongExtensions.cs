using System;

namespace VirtualWork.WinForms.Extensions
{
	public static class LongExtensions
	{
		private const double TwoToTheTenthPower = 1024;

		private static readonly string[] Sizes = new string[] { "", " KB", " MB", " GB", " TB", " PB", " EB", " ZB", " YB" };

		public static string GetHumanReadableSize(this long number)
		{
			int sizeIndex = 0;
			double testNumber = number;

			while (testNumber > TwoToTheTenthPower)
			{
				sizeIndex++;
				testNumber = testNumber / TwoToTheTenthPower;
			}

			return $"{String.Format("{0:0.00}", testNumber)}{Sizes[sizeIndex]}";
		}
	}
}
