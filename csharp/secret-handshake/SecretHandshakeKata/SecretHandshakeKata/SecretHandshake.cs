using System;
using System.Collections.Generic;

namespace SecretHandshakeKata
{
    public class SecretHandshake
    {
        private static string[] lookup = new string[]
        {
            "wink",
            "double blink",
            "close your eyes",
            "jump"
        };
        public static string[] Commands(int input)
        {
            var binary = Convert.ToString(input, 2).ToCharArray();
            Array.Reverse(binary);
            return GetCommands(binary);
        }

        private static string[] GetCommands(char[] binary)
        {
            var commands = new List<string>();
            var index = 0;
            while(index < binary.Length && index < 4)
            { 
                if(binary[index] =='1') commands.Add(lookup[index]);
                index++;
            }
            if(binary.Length == 5) commands.Reverse();
            return commands.ToArray();
        }
    }
}
