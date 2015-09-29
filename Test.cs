using NUnit.Framework;
using System;

namespace testing
{
	[TestFixture ()]
	public class Test
	{

		Calculator Calculator = new Calculator();

		[Test ()]
		public void AddOnePlusOne ()
		{

			int answer = Calculator.Add(1,1);

			Assert.AreEqual (2, answer);
		}

		[Test ()]
		public void MinusOnePlusOne ()
		{

			int answer = Calculator.Minus (1, 1);

			Assert.AreEqual (0, answer);
		}

		[Test ()]
		public void MultiplyTwoAndTwo ()
		{
			int answer = Calculator.Multiply (2, 2);

			Assert.AreEqual (4, answer);

		}


	}
}

