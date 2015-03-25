using System;
using System.Collections.Generic;

namespace fizzbuzz_tests
{
	public class Game
	{

		public static void Main (string[] args)
		{
			CreateDictionary ();
			GetInput ();
			GetNum (input);
			FizzBuzz(input, num, out string result);
			Console.WriteLine (result);
		}
			
		private static string FizzBuzz(string input, int num, out string result)
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

		private static dictionary CreateDictionary
		{
			CreateValues();
			AddValues();
		}

		private static dictionary CreateValues
		{
			Dictionary<int, string> values = new Dictionary<int, string> ();
		}

		private static dictionary AddValues
		{
			values.Add (3, "fizz");
			values.Add (5, "buzz");
			values.Add (15, "fizzbuzz");
		}
		private static string GetInput (out string input)
		{
			input = Console.ReadLine ();
		}

		private static int GetNum (string input, out int num)
		{
			num = int.Parse (input);
		}
	}
}