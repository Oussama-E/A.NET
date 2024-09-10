using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeApp
{
    public static class StringExtensions
    {
        public static bool IsAPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            // Enlever les espaces et convertir en minuscules pour ignorer la casse
            str = str.Replace(" ", "").ToLower();

            // Comparer le début et la fin de la chaîne
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false;
                }
            }

            return true;

        }
    }
}
