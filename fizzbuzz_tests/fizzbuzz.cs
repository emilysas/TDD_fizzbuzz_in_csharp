using System;
using System.Collections.Generic;

namespace fizzbuzz_tests
{
	public class Game
	{

		public static void Main (string[] args)
		{
			Dictionary<int, string> values = new Dictionary<int, string> ();
			AddValues ();
			string input = GetInput ();
			int num = GetNum (input);
			string result = FizzBuzz(input, num);
			Console.WriteLine (result);
		}
			
		public static string FizzBuzz(string input, int num)
		{
			var keys = values.Keys;
			foreach(var key in keys)
			{
				if (num % key == 0)
				{
					return values[key];
				}
				else
				{
					return input;
				}
			}
		}
	
		private static void AddValues()
		{
			values.Add (3, "fizz");
			values.Add (5, "buzz");
			values.Add (15, "fizzbuzz");
		}
		private static string GetInput ()
		{
			return Console.ReadLine ();
		}

		private static int GetNum (string input)
		{
			return int.Parse (input);
		}
	}
}