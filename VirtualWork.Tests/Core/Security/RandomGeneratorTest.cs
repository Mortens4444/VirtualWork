using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualWork.Core.Security;

namespace VirtualWork.Tests.Core.Security
{
	[TestClass]
	public class RandomGeneratorTest
	{
		private readonly RandomGenerator randomGenerator = new RandomGenerator();

		[TestMethod]
		public void GenerateRandomNumberNoRange()
		{
			AssertEx.ThrowsException<InvalidOperationException>(() => { randomGenerator.Generate(0, 0); });
		}

		[TestMethod]
		public void GenerateFixRandomNumber()
		{
			var result = randomGenerator.Generate(0, 1);
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void GenerateRandomNumber()
		{
			var result = randomGenerator.Generate(0, 5);
			Assert.IsTrue(result >= 0 && result < 5);
		}

		[TestMethod]
		public void GenerateRandomNumberMinToMax()
		{
			var result = randomGenerator.Generate(Int32.MinValue, Int32.MaxValue);
			Assert.IsTrue(result >= Int32.MinValue && result < Int32.MaxValue);
		}
	}
}
