using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests;

public class ContainsDuplicateIIITests
{
    [Test]
    public void Test1()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 1 };
        int indexDiff = 3;
        int valueDiff = 0;

        bool expected = true;

        // Act
        var result = ContainsDuplicateIII.ContainsNearbyAlmostDuplicate(nums, indexDiff, valueDiff);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[] nums = { 1, 5, 9, 1, 5, 9 };
        int indexDiff = 2;
        int valueDiff = 3;

        bool expected = false;

        // Act
        var result = ContainsDuplicateIII.ContainsNearbyAlmostDuplicate(nums, indexDiff, valueDiff);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}