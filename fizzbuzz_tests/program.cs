using System;


namespace fizzbuzz_tests
{
	public class Program
	{

		public static void Main (string[] args)
		{
			string input = GetInputFromUser ();
			int num = ConvertInputToNumber (input);
			FizzBuzz fizzbuzz = new FizzBuzz ();
			string result = fizzbuzz.Result(num);
			Console.WriteLine (result);
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