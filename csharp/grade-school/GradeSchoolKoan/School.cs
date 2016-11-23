using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Constraints;

namespace GradeSchoolKoan
{
	public class School
	{
		private Dictionary<int, List<string>> roster;

		public School()
		{
			roster = new Dictionary<int, List<string>>();
		}

		public Dictionary<int, List<string>> Roster
		{
			get
			{
				return roster;
			}
		}

		public void Add(string student, int grade)
		{
			if (GradeExists(grade))
			{
				roster[grade].Add(student);
				roster[grade].Sort();
			}
			else
			{
				roster.Add(grade, new List<string>() { student });
			}
		}

		public List<string> Grade(int grade)
		{
			if (!GradeExists(grade)) return new List<string>();
			return roster[grade];
		}

		private bool GradeExists(int grade)
		{
			return roster.ContainsKey(grade);
		}
	}
}
