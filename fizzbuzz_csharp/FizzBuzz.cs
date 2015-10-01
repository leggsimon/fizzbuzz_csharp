using System;
using System.Collections.Generic;

namespace fizzbuzz_csharp
{
	public class FizzBuzz
	{
		public List<string> GetFizzBuzz (int ceiling)
		{
			var numbers = new List<string> ();

			for (var i = 1; i <= ceiling; i++)
			{
				numbers.Add (GetNextFizzBuzz (i));
			}

			return numbers;
		}

		public string GetNextFizzBuzz(int position)
		{
			if (position % 15 == 0)
			{
				return "FizzBuzz";
			}
			if (position % 3 == 0)
			{
				return "Fizz";
			}
			if (position % 5 == 0)
			{
				return "Buzz";
			}
			return position.ToString();
		}
	}
}

