using System;

namespace testing
{
	public class MorseCode
	{
		public String LetterToMorseCode (String letter){
			if (letter.ToLower () == "a") {
				return ".-"; 
			}
				
			if (letter.ToLower () == "b") {
				return "-...";
			}

			throw new ArgumentException ("Unexpected letter");
		}
	}
}

