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
            string str1 = "abccba";
            string str2 = "abb";

            //act
            bool isPal1 = pal.isPalindrome(str1);
            bool isPal2 = pal.isPalindrome(str2);

            //assert
            Assert.True(isPal1);
            Assert.False(isPal2);
        }

        [Fact]
        public void Test2()
        {
            PalindromeChecker pal = new PalindromeChecker();
            string str1 = "a,b, s";

            string str2 = pal.removePuncAndSpaces(str1);

            Assert.Equal("abs", str2);

        }
    }
}
