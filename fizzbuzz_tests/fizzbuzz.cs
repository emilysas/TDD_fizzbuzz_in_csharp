using System;
using System.Collections.Generic;

namespace fizzbuzz_tests
{
	public class FizzBuzz
	{		
		public FizzBuzz()
		{
			CreateValues ();
			AddValues ();
		}

		Dictionary<int, string> values;

		private void CreateValues() {
			values = new Dictionary<int, string> ();
		}

		private void AddValues()
		{
			values.Add (15, "fizzbuzz");
			values.Add (3, "fizz");
			values.Add (5, "buzz");
		}

		public string Result (int num)
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
	}
}

