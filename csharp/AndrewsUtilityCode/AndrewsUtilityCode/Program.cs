using System;
using System.Collections.Generic;
using System.Linq;
using AndrewsUtilityCode.Classes;

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
			Output.PrintQueryResult(stringQuery);

			// Select all chars before dash
			IEnumerable<char> charsBeforeDash = aString.TakeWhile(c => c != '-');

			// Execute second query and print result
			Output.PrintQueryResult(charsBeforeDash);

			// Demo PrintQueryResult using ints
			Console.WriteLine("DEMO PRINTQUERYRESULT USING INTS");

			int[] arr = new int[] { 1, 2, 3, 4 };
			IEnumerable<int> nums = arr.Skip(1).ToArray();
			Output.PrintQueryResult(nums, "Numbers!");

			// Demo PrintQueryResult using custom type
			List<Student> studentList = new List<Student>();

			studentList.Add(new Student()
			{
				FirstName = "Winnie",
				LastName = "the Pooh",
				ID = 130,
				ExamScores = new List<int> { 79, 83, 81, 97 }
			});

			studentList.Add(new Student()
			{
				FirstName = "Christopher",
				LastName = "Robin",
				ID = 131,
				ExamScores = new List<int> { 88, 85, 89, 95 }
			});

			IEnumerable<string> students = from student in studentList
										  where student.FirstName != null
										  select student.FirstName + " " + student.LastName;

			Output.PrintQueryResult(students, $"Generic collection of custom type Student: ");
		}
	}

	// Class to serve as data model for testing generic version of PrintQueryResult()
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int ID { get; set; }
		public List<int> ExamScores { get; set; }
	}
}
