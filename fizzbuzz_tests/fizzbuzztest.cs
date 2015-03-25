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
			Game game = new Game();
			Assert.AreEqual ("fizz", game.FizzBuzz ("3", 3));
		}
			
	}
}

