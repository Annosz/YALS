using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            string s = "abcabcbb";

            int expected = 3;

            // Act
            var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            string s = "bbbbb";

            int expected = 1;

            // Act
            var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            // Arrange
            string s = "pwwkew";

            int expected = 3;

            // Act
            var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}