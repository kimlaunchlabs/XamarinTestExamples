using System;
using System.Collections.Generic;

namespace BasicInputOutputSample
{
	public static class NumberConversion
	{
		// int to string
		public static string AmountInWords(double amount)
		{
			var n = (int)amount;

			if (n == 0)
				return "";
			else if (n > 0 && n <= 19) {
				var arr = new string[] {
					"One",
					"Two",
					"Three",
					"Four",
					"Five",
					"Six",
					"Seven",
					"Eight",
					"Nine",
					"Ten",
					"Eleven",
					"Twelve",
					"Thirteen",
					"Fourteen",
					"Fifteen",
					"Sixteen",
					"Seventeen",
					"Eighteen",
					"Nineteen"
				};
				return arr [n - 1] + " ";
			} else if (n >= 20 && n <= 99) {
				var arr = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
				return arr [n / 10 - 2] + " " + AmountInWords (n % 10);
			} else if (n >= 100 && n <= 199) {
				return "One Hundred " + AmountInWords (n % 100);
			} else if (n >= 200 && n <= 999) {
				return AmountInWords (n / 100) + "Hundred " + AmountInWords (n % 100);
			} else if (n >= 1000 && n <= 1999) {
				return "One Thousand " + AmountInWords (n % 1000);
			} else if (n >= 2000 && n <= 999999) {
				return AmountInWords (n / 1000) + "Thousand " + AmountInWords (n % 1000);
			} else if (n >= 1000000 && n <= 1999999) {
				return "One Million " + AmountInWords (n % 1000000);
			} else if (n >= 1000000 && n <= 999999999) {
				return AmountInWords (n / 1000000) + "Million " + AmountInWords (n % 1000000);
			} else if (n >= 1000000000 && n <= 1999999999) {
				return "One Billion " + AmountInWords (n % 1000000000);
			} else {
				return AmountInWords (n / 1000000000) + "Billion " + AmountInWords (n % 1000000000);
			}

		}

		// string to int
		public static int ParseEnglish(string number) {
			string[] words = number.ToLower().Split(new char[] {' ', '-', ','}, StringSplitOptions.RemoveEmptyEntries);
			string[] ones = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
			string[] teens = {"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
			string[] tens = {"ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
			Dictionary<string, int> modifiers = new Dictionary<string, int>() {
				{"billion", 1000000000},
				{"million", 1000000},
				{"thousand", 1000},
				{"hundred", 100}
			};

			if(number == "eleventy billion")
				return int.MaxValue; // 110,000,000,000 is out of range for an int!

			int result = 0;
			int currentResult = 0;
			int lastModifier = 1;

			foreach(string word in words) {
				if(modifiers.ContainsKey(word)) {
					lastModifier *= modifiers[word];
				} else {
					int n;

					if(lastModifier > 1) {
						result += currentResult * lastModifier;
						lastModifier = 1;
						currentResult = 0;
					}

					if((n = Array.IndexOf(ones, word) + 1) > 0) {
						currentResult += n;
					} else if((n = Array.IndexOf(teens, word) + 1) > 0) {
						currentResult += n + 10;
					} else if((n = Array.IndexOf(tens, word) + 1) > 0) {
						currentResult += n * 10;
					} else if(word != "and") {
						
						throw new Exception("Unrecognized word: " + word);
					}
				}
			}

			return result + currentResult * lastModifier;
		}
	}
}

