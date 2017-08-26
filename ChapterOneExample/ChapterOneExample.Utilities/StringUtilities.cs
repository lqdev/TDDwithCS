using System;

namespace ChapterOneExamples.Utilities
{
	public class StringUtilities
	{
		public int CountOccurrences(string stringToCheck, string stringToFind)
		{
			
			if(stringToCheck == null) return -1;

			var stringAsCharArray = stringToCheck.ToUpper().ToCharArray();
			var stringToCheckForAsChar = stringToFind.ToUpper().ToCharArray()[0];

			var occurrenceCount = 0;

			for (var characterIndex = 0; characterIndex <= stringAsCharArray.GetUpperBound(0);characterIndex++) 
			{
				if(stringAsCharArray[characterIndex] == stringToCheckForAsChar)
				{
					occurrenceCount++;
				}
			}

			return occurrenceCount;
		}
	}
}