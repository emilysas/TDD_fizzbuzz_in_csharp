using NUnit.Framework;
using System;

namespace fizzbuzz_tests
{

	[TestFixture]
	public class FizzBuzzTest
	{
		FizzBuzz fizzbuzz;

		[SetUp]
		public void Init()
		{
			fizzbuzz = new FizzBuzz ();
		}

		[Test]
		public void FizzIfDivisibleBy3()
		{
			Assert.AreEqual ("fizz", fizzbuzz.Result (3));
		}

		[Test]
		public void BuzzIfDivisibleByf5()
		{
			Assert.AreEqual ("buzz", fizzbuzz.Result (5));
		}

		[Test]
		public void FizzBuzzIfDivisibleBy15()
		{
			Assert.AreEqual ("fizzbuzz", fizzbuzz.Result (15));
		}
	}
}

