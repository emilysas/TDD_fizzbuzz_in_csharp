using NUnit.Framework;
using System;

namespace fizzbuzz_tests
{

	[TestFixture]
	public class FizzBuzzTest
	{

		[Test]
		public void FizzIfFactorOf3()
		{
			var fizzbuzz = new FizzBuzz ();
			Assert.AreEqual ("fizz", fizzbuzz.Result (3));
		}

		public void BuzzIfFactorOf5()
		{
			var fizzbuzz = new FizzBuzz ();
			Assert.AreEqual ("buzz", fizzbuzz.Result (5));
		}
	}
}

