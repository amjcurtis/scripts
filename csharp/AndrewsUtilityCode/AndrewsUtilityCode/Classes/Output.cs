using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndrewsUtilityCode.Classes
{
	public static class Output
	{
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
