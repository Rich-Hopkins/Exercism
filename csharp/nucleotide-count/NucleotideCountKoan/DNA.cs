using System;
using System.Collections.Generic;

namespace NucleotideCountKoan
{
	public class DNA
	{
		private Dictionary<char, int> nucleotideCounts = new Dictionary<char, int>(){
			{ 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 }
		};

		public DNA(string strand)
		{
			foreach (char c in strand)
			{
				nucleotideCounts[c] += 1;
			}
		}
		
		public Dictionary<char, int> NucleotideCounts()
		{
			return nucleotideCounts;
		}

		public int Count(char c)
		{
			if (InvalidNucleotide(c)) throw new InvalidNucleotideException();
			return nucleotideCounts[c];
		}

		private bool InvalidNucleotide(char c)
		{
			return !nucleotideCounts.ContainsKey(c);
		}
	}

	public class InvalidNucleotideException : Exception
	{
	}
}
