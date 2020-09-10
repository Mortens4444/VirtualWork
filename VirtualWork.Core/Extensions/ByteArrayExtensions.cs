using System.Drawing;
using System.IO;
using System.Text;

namespace VirtualWork.Core.Extensions
{
	public static class ByteArrayExtensions
	{
		/// <summary>
		/// From a byte array creates a string
		/// </summary>
		/// <param name="bytes">The byte array</param>
		/// <returns>Ex.: [12][23][64][78]</returns>
		public static string ToArrayString(this byte[] bytes)
		{
			var result = new StringBuilder();
			foreach (var @byte in bytes)
			{
				result.AppendFormat("[{0}]", @byte);
			}
			return result.ToString();
		}


		public static string ToArrayString(this byte[] bytes, int startIndex, int endIndex)
		{
			var result = new StringBuilder();
			for (var i = startIndex; i < endIndex; i++)
			{
				result.AppendFormat("[{0}]", bytes[i]);
			}
			return result.ToString();
		}

		public static Image ToImage(this byte[] bytes)
		{
			if (bytes == null || bytes.Length == 0)
			{
				return null;
			}

			using (var memoryStream = new MemoryStream(bytes))
			{
				return Image.FromStream(memoryStream);
			}
		}
	}
}
