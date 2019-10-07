using Palindrome.Library;
using System;
using Xunit;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            PalindromeChecker pal = new PalindromeChecker();
            string str = "abccba";

            //act
            bool isPal = pal.isPalindrome(str);
            
            //assert
        }
    }
}
