using System;
using System.Collections.Generic;
using System.Linq;

namespace AndrewsUtilityCode
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("DEMO PRINTQUERYRESULT USING CHARS");

			string aString = "ABCDE99F-J74-12-06A";
			Console.WriteLine("Original string: {0}", aString);

			// Select only the chars that are numbers
			IEnumerable<char> stringQuery = from ch in aString
											where Char.IsDigit(ch)
											select ch;

			// Execute query and print results
			PrintQueryResult(stringQuery);

			// Select all chars before dash
			IEnumerable<char> charsBeforeDash = aString.TakeWhile(c => c != '-');

			// Execute second query and print result
			PrintQueryResult(charsBeforeDash);

			// Demo PrintQueryResult using ints
			Console.WriteLine("DEMO PRINTQUERYRESULT USING INTS");

			int[] arr = new int[] { 1, 2, 3, 4 };
			IEnumerable<int> nums = arr.Skip(1).ToArray();
			PrintQueryResult(nums, "Numbers!");

			Console.ReadLine();
		}

		/// <summary>
		/// Executes a LINQ query and writes results to console.
		/// </summary>
		/// <param name="query">Query to output results of.</param>
		/// <param name="message">Accompanying message to write to console.</param>
		public static void PrintQueryResult(IEnumerable<string> query, string message)
		{
			Console.WriteLine(System.Environment.NewLine + message);
			foreach (string str in query)
			{
				Console.WriteLine(str);
			}
			Console.WriteLine("{0} total item(s) in list", query.Count());
		}

		// Overload for PrintQueryResult
		/// <summary>
		/// Executes a LINQ query and writes results to console.
		/// </summary>
		/// <param name="query">Query to output results of.</param>
		public static void PrintQueryResult(IEnumerable<string> query)
		{
			Console.WriteLine(System.Environment.NewLine);
			foreach (string str in query)
			{
				Console.WriteLine(str);
			}
			Console.WriteLine("{0} total item(s) in list", query.Count());
		}

		// Overload for PrintQueryResult
		/// <summary>
		/// Executes a LINQ query and writes results to console.
		/// </summary>
		/// <param name="query">Query to output results of.</param>
		/// <param name="message">Accompanying message to write to console.</param>
		public static void PrintQueryResult(IEnumerable<char> query, string message)
		{
			Console.WriteLine(System.Environment.NewLine + message);
			foreach (char c in query)
			{
				Console.WriteLine(c);
			}
			Console.WriteLine("{0} total item(s) in list", query.Count());
		}

		// Overload for PrintQueryResult
		/// <summary>
		/// Executes a LINQ query and writes results to console.
		/// </summary>
		/// <param name="query">Query to output results of.</param>
		public static void PrintQueryResult(IEnumerable<char> query)
		{
			Console.WriteLine(System.Environment.NewLine);
			foreach (char c in query)
			{
				Console.WriteLine(c);
			}
			Console.WriteLine("{0} total item(s) in list", query.Count());
		}

		// Overload for PrintQueryResult
		/// <summary>
		/// Executes a LINQ query and writes results to console.
		/// </summary>
		/// <param name="query">Query to output results of.</param>
		/// <param name="message">Accompanying message to write to console.</param>
		public static void PrintQueryResult(IEnumerable<int> query, string message)
		{
			Console.WriteLine(System.Environment.NewLine + message);
			foreach (int num in query)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine(System.Environment.NewLine, "{0} total item(s) in list", query.Count());
		}

		// Overload for PrintQueryResult
		/// <summary>
		/// Executes a LINQ query and writes results to console.
		/// </summary>
		/// <param name="query">Query to output results of.</param>
		public static void PrintQueryResult(IEnumerable<int> query)
		{
			Console.WriteLine(System.Environment.NewLine);
			foreach (int num in query)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine(System.Environment.NewLine, "{0} total item(s) in list", query.Count());
		}
	}
}
