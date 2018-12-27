using System;

namespace PalindromeFinder
{
    class FindPalindrome
    {
        static void Main(string[] args)
        {
            //get and store input as word
            Console.WriteLine("Please type a word that you want to check is a palindrome:");
            var word = Console.ReadLine();

            //A palindrome must read the same from reverse and regular

            var palindromeFound = IterateThroughPalindrome(word);

            if (palindromeFound)
            {
                //word is a palindrome
                Console.WriteLine("\nThe word entered is a palindrome.");
            }
            else
            {
                //word is NOT a palindrome
                Console.WriteLine("\nThe word entered is NOT a palindrome.");
            }
        }

        static bool IterateThroughPalindrome(string word)
        {
            //linear search
            for (int x = 0; x < MathF.Floor(word.Length / 2) + 1; x++)
            {
                if (x == MathF.Floor(word.Length / 2))
                {
                    //current index at center, word is palindrome because all characters are in the same order left and right of center
                    return true;
                }

                if (word[x] == word[(word.Length - x - 1)])
                {
                    //letter does match letter at reflected index
                    continue;
                }
                else
                {
                    //letter does NOT match letter at reflected index
                    break;
                }
            }
            //palindrome not found
            return false;
        }
    }
}
