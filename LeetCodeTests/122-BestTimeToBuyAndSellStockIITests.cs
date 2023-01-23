using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests;

public class BestTimeToBuyAndSellStockIITests
{
    [Test]
    public void Test1()
    {
        // Arrange
        int[] prices = { 7, 1, 5, 3, 6, 4 };

        int expected = 7;

        // Act
        var result = BestTimeToBuyAndSellStockII.MaxProfit(prices);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[] prices = { 1, 2, 3, 4, 5 };

        int expected = 4;

        // Act
        var result = BestTimeToBuyAndSellStockII.MaxProfit(prices);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        // Arrange
        int[] prices = { 7, 6, 4, 3, 1 };

        int expected = 0;

        // Act
        var result = BestTimeToBuyAndSellStockII.MaxProfit(prices);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}