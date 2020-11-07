using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualWork.Tests
{
	public static class AssertEx
	{
		public static void ThrowsException<T>(Action task)
			where T : Exception
		{
			try
			{
				task();
			}
			catch (T)
			{
				return;
			}
			Assert.Fail($"Expected {typeof(T).Name}");
		}
	}
}
