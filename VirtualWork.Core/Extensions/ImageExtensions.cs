﻿using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace VirtualWork.Core.Extensions
{
	public static class ImageExtensions
	{
		public static byte[] ToByteArray(this Image image)
		{
			if (image == null)
			{
				return new byte[] { };
			}

			using (var memoryStream = new MemoryStream())
			{
				image.Save(memoryStream, ImageFormat.Png);
				return memoryStream.ToArray();
			}
		}
	}
}
