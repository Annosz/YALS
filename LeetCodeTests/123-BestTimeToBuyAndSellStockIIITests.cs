using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests;

public class BestTimeToBuyAndSellStockIIITests
{
    [Test]
    public void Test1()
    {
        // Arrange
        int[] prices = { 3, 3, 5, 0, 0, 3, 1, 4 };

        int expected = 6;

        // Act
        var result = BestTimeToBuyAndSellStockIII.MaxProfit(prices);

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
        var result = BestTimeToBuyAndSellStockIII.MaxProfit(prices);

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
        var result = BestTimeToBuyAndSellStockIII.MaxProfit(prices);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}