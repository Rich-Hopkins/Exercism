using System;
using System.Collections.Generic;
using System.Linq;

namespace KindergartenKoan
{
	public enum Plant
	{
		Radishes, Clover, Grass, Violets
	}
	public class Garden
	{
		private string[] kids;
		private string[] plantRows;
		private Dictionary<string, Plant> plantLookup = new Dictionary<string, Plant>()
		{
			{"R", Plant.Radishes },
			{"C", Plant.Clover },
			{"G", Plant.Grass },
			{"V", Plant.Violets }
		};

		public Garden(string[] children, string plants)
		{
			Array.Sort(children);
			kids = children;
			plantRows = plants.Split('\n');
		}

		public static Garden DefaultGarden(string plants)
		{
			return new Garden(new string[] {
				"Alice", "Bob", "Charlie", "David",
				"Eve", "Fred", "Ginny", "Harriet",
				"Ileana", "Joseph", "Kincaid", "Larry"},
			plants);
		}

		public Plant[] GetPlants(string child)
		{
			if (!kids.Contains(child)) return new Plant[0];
			
			var childsPlants = new Plant[4];
			var nameIndex = Array.IndexOf(kids, child);
			BuildPlantArray(childsPlants, nameIndex);
			return childsPlants;
		}

		private void BuildPlantArray(Plant[] plantArray, int nameIndex)
		{
			int arrayIndex = 0;
			var letters =
				(plantRows[0].Substring(nameIndex * 2, 2) 
				+ plantRows[1].Substring(nameIndex * 2, 2))
				.ToCharArray();

			foreach (var letter in letters)
			{
				plantArray[arrayIndex] = plantLookup[letter.ToString()];
				arrayIndex++;
			}
		}
	}
}
