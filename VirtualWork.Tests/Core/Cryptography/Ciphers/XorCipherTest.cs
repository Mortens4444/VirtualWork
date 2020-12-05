using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualWork.Core.Cryptography.Ciphers;

namespace VirtualWork.Tests.Core.Cryptography.Ciphers
{
	[TestClass]
	public class XorCipherTest
	{
		private readonly XorCipher xorCipher = new XorCipher();

		[TestMethod]
		public void Encrypt()
		{
			var plaintText = "abc";
			var key = "123";
			var expectedEncryptedText = "PPP";

			var start = Environment.TickCount;
			var encryptedText = xorCipher.Encrypt(plaintText, key);
			var end = Environment.TickCount;
			var duration = end - start;
			Console.WriteLine(duration);
			Assert.AreEqual(expectedEncryptedText, encryptedText);
			var decryptedText = xorCipher.Encrypt(encryptedText, key);
			Assert.AreEqual(plaintText, decryptedText);
		}
	}
}
