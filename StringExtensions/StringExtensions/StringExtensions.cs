using System;
using System.Collections.Generic;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static bool HasAllUniqueChars(this string input) 
        {
            IDictionary<char, int> chars = new Dictionary<char, int>();
            foreach (var character in input) 
            {
                if (chars.ContainsKey(character)) return false;
                chars.Add(character, 1);         
            }
            return true;
        }

        public static string Reverse(this string input) 
        {
            var chars = input.ToCharArray();
            var halvedLength = chars.Length / 2;
            for (var i = 0; i < halvedLength; i++) 
            {
                var swap = chars[i];
                chars[i] = chars[(chars.Length-1)-i];
                chars[(chars.Length-1)-i] = swap;
            }
            return new string(chars);
        }

        public static string ReplaceSpace20(this string input) 
        {
            var chars = input.ToCharArray();
            int spaceCount = 0;
            for(int i = 0; i < chars.Length; i++) 
            {
                if (chars[i] == ' ') spaceCount++;
            }
            int newLength = chars.Length + spaceCount * 2;
            var newString = new char[newLength];
            for(int i = 0, j = 0; i < chars.Length; i++) 
            {
                if (chars[i] != ' ') newString[j++] = chars[i];
                else {
                    newString[j++] = '%';
                    newString[j++] = '2';
                    newString[j++] = '0';
                }
            }
            return new string(newString);
        }
    }
}
