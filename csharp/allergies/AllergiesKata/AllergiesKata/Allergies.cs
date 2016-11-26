using System;
using System.Collections.Generic;

namespace AllergiesKata
{
    public class Allergies
    {
        private string[] allergens =
        {
            "eggs", "peanuts", "shellfish", "strawberries",
            "tomatoes", "chocolate", "pollen", "cats"
        };
        private char[] allergenCodes;

        public Allergies(int score)
        {
            var convertedScore = 
                Convert.ToString(score, 2).PadLeft(8, '0');
            allergenCodes = 
                convertedScore.Substring(convertedScore.Length - 8).ToCharArray();
            Array.Reverse(allergenCodes);
        }

        public bool AllergicTo(string allergen)
        {
            return List().Contains(allergen);
        }

        public List<string> List()
        {
            var allergenList = new List<string>();
            for(var i = 0; i < allergenCodes.Length; i++)
            {
                if(allergenCodes[i] == '1')
                    allergenList.Add(allergens[i]);
            }
            return allergenList;
        }
    }
}
