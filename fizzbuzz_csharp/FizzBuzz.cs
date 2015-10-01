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
				if (i % 3 == 0) 
				{
					numbers.Add ("Fizz");
				}
				else
				{
					numbers.Add(i.ToString());
				}
			}

			return numbers;
		}
	}
}

