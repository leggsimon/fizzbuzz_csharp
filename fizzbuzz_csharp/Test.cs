using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace fizzbuzz_csharp
{


	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestFizzBuzz_ShouldReturnTwoIntegers()
		{
			var fizzbuzz = new FizzBuzz ();
			var expected = new List<int>{1,2};
		
			var actual = fizzbuzz.GetFizzBuzz ();

			CollectionAssert.AreEqual (expected, actual);
		}
	}
}

