using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests;

public class ContainsDuplicateIITests
{
    [Test]
    public void Test1()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 1 };
        int k = 3;

        bool expected = true;

        // Act
        var result = ContainsDuplicateII.ContainsNearbyDuplicate(nums, k);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[] nums = { 1, 0, 1, 1 };
        int k = 1;

        bool expected = true;

        // Act
        var result = ContainsDuplicateII.ContainsNearbyDuplicate(nums, k);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 1, 2, 3 };
        int k = 2;

        bool expected = false;

        // Act
        var result = ContainsDuplicateII.ContainsNearbyDuplicate(nums, k);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}