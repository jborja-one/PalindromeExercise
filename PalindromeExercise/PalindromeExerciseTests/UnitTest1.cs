using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("hello", false)]
        public void Test1(string word, bool expected)
        {
            WordSmith result = new WordSmith();
            bool actual = result.IsPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
