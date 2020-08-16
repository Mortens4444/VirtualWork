﻿using System;
using System.IO;
using System.Text;

namespace VirtualWork.Service.FileHandling
{
	public class FileReader
	{
		public string[] LoadFile(string filename)
		{
			return LoadFile(filename, Environment.NewLine);
		}

		public string[] LoadFile(string filename, string separator)
		{
			string[] result = null;
			if (File.Exists(filename))
			{
				using (var fileStream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
				{
					using (var streamReader = new StreamReader(fileStream))
					{
						var content = streamReader.ReadToEnd();
						streamReader.Close();
						result = content.Split(new[] { separator }, Int32.MaxValue, StringSplitOptions.None);
					}
					fileStream.Close();
				}
			}
			return result;
		}

		public string GetFileContent(string filename)
		{
			string result;
			if (File.Exists(filename))
			{
				using (var fileStream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
				{
					using (var streamReader = new StreamReader(fileStream, Encoding.Default))
					{
						result = streamReader.ReadToEnd();
						streamReader.Close();
					}
					fileStream.Close();
				}
			}
			else
			{
				throw new FileNotFoundException($"File not found: {filename}", filename);
			}
			return result;
		}
	}

}
