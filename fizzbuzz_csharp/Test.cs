﻿using NUnit.Framework;
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
			var expected = new List<string>{ "1", "2" };
		
			var actual = fizzbuzz.GetFizzBuzz (2);

			CollectionAssert.AreEqual (expected, actual);
		}

		[Test ()]
		public void TestFizzBuzz_ShouldReturnFirstThreeItems()
		{
			var fizzbuzz = new FizzBuzz ();
			var expected = new List<string>{ "1", "2", "Fizz" };

			var actual = fizzbuzz.GetFizzBuzz (3);

			CollectionAssert.AreEqual (expected, actual);
		}
	}
}

