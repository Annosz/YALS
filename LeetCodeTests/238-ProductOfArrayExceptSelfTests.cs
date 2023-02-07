using NUnit.Framework;

namespace LeetCode;

public class ProductOfArrayExceptSelfTests
{
    [Test]
    public void Test1()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4 };

        int[] expected = { 24, 12, 8, 6 };

        // Act
        var result = ProductOfArrayExceptSelf.ProductExceptSelf(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[] nums = { -1, 1, 0, -3, 3 };

        int[] expected = { 0, 0, 9, 0, 0 };

        // Act
        var result = ProductOfArrayExceptSelf.ProductExceptSelf(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}