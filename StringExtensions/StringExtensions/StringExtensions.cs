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
            var index = chars.Length - 1;
            if (chars[index] != ' ') return input; // nothing to replace
            for (; index >= 0; index--) 
            {
                
            }
            return new string(chars);
        }
    }
}
