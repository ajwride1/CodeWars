using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class DisemvowellTrolls
    {
        private static List<char> _Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A','E','I','O','U' };
        public static string Disemvowel(string str)
        {
            char[] characters = str.ToCharArray();

            foreach (char character in characters.Where(c => c != ' ').Distinct())
            {
                if (_Vowels.Contains(character))
                    str = str.Replace(character.ToString(), string.Empty);
            }

            return str;
        }

        public static string Alternate(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }
    }
}
