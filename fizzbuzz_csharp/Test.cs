using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace fizzbuzz_csharp
{


	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestFizzBuzz_ShouldReturnTwoIntegers ()
		{
			var fizzbuzz = new FizzBuzz ();
			var expected = new List<string>{ "1", "2" };

			var actual = fizzbuzz.GetFizzBuzz (2);

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test ()]
		public void TestFizzBuzz_ShouldReturnFirstThreeItems ()
		{
			var fizzbuzz = new FizzBuzz ();
			var expected = new List<string>{ "1", "2", "Fizz" };

			var actual = fizzbuzz.GetFizzBuzz (3);

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test ()]
		public void TestFizzBuzz_ShouldReturnFirstFiveItems ()
		{
			var fizzbuzz = new FizzBuzz ();
			var expected = new List<string>{ "1", "2", "Fizz", "4", "Buzz" };

			var actual = fizzbuzz.GetFizzBuzz (5);

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test ()]
		public void TestFizzBuzz_Given15thPosition_ShouldReturnFizzBuzz ()
		{
			var fizzbuzz = new FizzBuzz ();
			var position = 15;
			var expected = "FizzBuzz";

			var totalFizzBuzzList = fizzbuzz.GetFizzBuzz (15);
			var actual = totalFizzBuzzList [position - 1];

			CollectionAssert.AreEqual (expected, actual);
		}
	}
}
