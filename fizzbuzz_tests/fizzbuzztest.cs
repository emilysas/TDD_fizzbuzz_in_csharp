using NUnit.Framework;
using System;

namespace fizzbuzz_tests
{

	[TestFixture]
	public class FizzBuzz
	{

		[Test]
		public void FizzIfFactorOf3()
		{
			var fizzbuzz = new FizzBuzz ();
			Assert.AreEqual ("fizz", fizzbuzz.Result (3));
		}
			
	}
}

