using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests;

public class ContainsDuplicateTests
{
    [Test]
    public void Test1()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 1 };

        bool expected = true;

        // Act
        var result = ContainsDuplicate.ContainsDuplicateX(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4 };

        bool expected = false;

        // Act
        var result = ContainsDuplicate.ContainsDuplicateX(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        // Arrange
        int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        bool expected = true;

        // Act
        var result = ContainsDuplicate.ContainsDuplicateX(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}