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

        public Allergies(int allergyCode)
        {
            var allergens = 
                Convert.ToString(allergyCode, 2).PadLeft(8, '0');
            allergenCodes = 
                allergens.Substring(allergens.Length - 8).ToCharArray();
            Array.Reverse(allergenCodes);
        }

        public bool AllergicTo(string allergen)
        {
            return allergenCodes[Array.IndexOf(allergens, allergen)] == '1';
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
