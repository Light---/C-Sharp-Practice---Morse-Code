using NUnit.Framework;
using System;

namespace testing
{
	[TestFixture()]
	public class MorseCodeTest
	{
		MorseCode MorseCode = new MorseCode();

		[Test ()]
		public void LetterToMorseCodeWithLowerCaseA ()
		{

			String answer = MorseCode.LetterToMorseCode("a");

			Assert.AreEqual (".-", answer);
		}

		[Test ()]
		public void LetterToMorseCodeWithUpperCaseA ()
		{

			String answer = MorseCode.LetterToMorseCode("A");

			Assert.AreEqual (".-", answer);
		}

		[Test ()]
		public void LetterToMorseCodeWithLowerCaseB ()
		{

			String answer = MorseCode.LetterToMorseCode("b");

			Assert.AreEqual ("-...", answer);
		}

		[Test ()]
		public void LetterToMorseCodeWithUpperCaseB ()
		{

			String answer = MorseCode.LetterToMorseCode("B");

			Assert.AreEqual ("-...", answer);
		}

		
	}
}

