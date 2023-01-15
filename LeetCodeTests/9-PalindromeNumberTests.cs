using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests;

public class PalindromeNumberTests
{
    [Test]
    public void Test1()
    {
        // Arrange
        int x = 121;

        bool expected = true;

        // Act
        var result = PalindromeNumber.IsPalindrome(x);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int x = -121;

        bool expected = false;

        // Act
        var result = PalindromeNumber.IsPalindrome(x);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        // Arrange
        int x = 10;

        bool expected = false;

        // Act
        var result = PalindromeNumber.IsPalindrome(x);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}