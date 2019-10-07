using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class PalindromeChecker
    {

        /*
         * Returns whether or not the given string input is a palindrome
         * 
         */
        public bool isPalindrome(string str)
        {
            // check if null
            if (str == null)
            {
                return false;
            }

            str = removePuncAndSpaces(str);

            // reverse stores str in reverse
            char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);

            // if str is a palindrome, 
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != reverse[i])
                {
                    return false;
                }
            }
            return true;
        }

        // Removes punctuation from a string
        public string removePuncAndSpaces(string str) 
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                // if current char in str is punctuation or a space, skip inserting current char
                if (Char.IsPunctuation(str[i]) || str[i] == ' ')
                {
                    i += 1;
                } else
                {
                    result += str[i];
                }
            }
            return result;
        }

    }
}
