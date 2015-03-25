using System;
using System.Collections.Generic;

namespace fizzbuzz_tests
{
	public class Game
	{
		private static Dictionary<int, string> values = new Dictionary<int, string> ();
		values.Add (3, "fizz");
		//				.Add (5, "buzz")
		//				.Add (15, "fizzbuzz");

		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			int num = int.Parse (input);


			string result;
			FizzBuzz(input, num, out result);
			Console.WriteLine (result);
		}
			
		public static string FizzBuzz(string input, int num, out string result)
		{

			var keys = values.Keys;
			foreach(var key in keys)
			{
				if (num % key == 0)
				{
					result = values[key];
				}
				else
				{
					result = input;
				}
			}
		}
	}
}