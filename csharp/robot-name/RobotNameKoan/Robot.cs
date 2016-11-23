using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotNameKoan
{
	public class Robot
	{
		private static Random random = new Random();
		private static List<string> usedNames = new List<string>();

		public Robot()
		{
			GenerateName();
		}

		private void GenerateName()
		{
			string newName;
			do
			{
				string letterArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
				string numberArray = "0123456789";
				var letters = Enumerable.Range(0, 2)
					.Select(x => letterArray[random.Next(0, letterArray.Length)]);
				var numbers = Enumerable.Range(0, 3)
					.Select(x => numberArray[random.Next(0, numberArray.Length)]);
				newName = new string(letters.ToArray()) + new string(numbers.ToArray());

			} while (usedNames.Contains(newName));
			usedNames.Add(newName);
			Name = newName;
		}

		public string Name { get; private set; } = "";

		public void Reset()
		{
			GenerateName();
		}
	}
}
