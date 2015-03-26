using System;
using System.Collections.Generic;

namespace fizzbuzz_tests
{
	public class Program
	{
		private static Dictionary<int, string> values;

		private static void CreateValues() {
			values = new Dictionary<int, string> ();
		}

		public static void Main (string[] args)
		{
			CreateValues ();
			AddValues ();
			string input = GetInputFromUser ();
			int num = ConvertInputToNumber (input);
			string result = FizzBuzz(num);
			Console.WriteLine (result);
		}
			
		public static string FizzBuzz(int num)
		{
			var keys = values.Keys;

			foreach(var key in keys)
			{
				if (num % key == 0) {
					return values [key];
				} 
			}

			return num.ToString();
		
		}
	
		private static void AddValues()
		{
			values.Add (3, "fizz");
			values.Add (5, "buzz");
			values.Add (15, "fizzbuzz");
		}

		private static string GetInputFromUser ()
		{
			return Console.ReadLine ();
		}

		private static int ConvertInputToNumber (string input)
		{
			return int.Parse (input);
		}
	}
}