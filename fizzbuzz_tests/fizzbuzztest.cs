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
		public void FizzIfFactorOf3()
		{
			Assert.AreEqual ("fizz", fizzbuzz.Result (3));
		}

		[Test]
		public void BuzzIfFactorOf5()
		{
			Assert.AreEqual ("buzz", fizzbuzz.Result (5));
		}
	}
}

