// See https://aka.ms/new-console-template for more information
using PalindromeApp;

namespace PalindromeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "été";
            string word2 = "radar";
            string word3 = "Hello";

            Console.WriteLine($"'{word1}' est un palindrome : {word1.IsAPalindrome()}");
            Console.WriteLine($"'{word2}' est un palindrome : {word2.IsAPalindrome()}");
            Console.WriteLine($"'{word3}' est un palindrome : {word3.IsAPalindrome()}");

        }
    }
}