using System;
using System.Collections.Generic;

namespace fizzbuzz_tests
{
	public class Game
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			int num = int.Parse (input);

			Dictionary<int, string> dictionary = new Dictionary<int, string> ();

			dictionary.Add (3, "fizz")
//				.Add (5, "buzz")
//				.Add (15, "fizzbuzz");

			FizzBuzz(input, num, dictionary);

		}

		string value;

		public static FizzBuzz(string input, int num, dictionary dictionary, out string)
		{

			var keys = dictionary.Keys;
			foreach(var key in keys)
			{
				if (num % key == 0)
				{
					Console.WriteLine (dictionary[key]);
				}
				else
				{
					Console.WriteLine (input);
				}
			}
		}
	}
}