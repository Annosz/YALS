using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests;

public class BestTimeToBuyAndSellStockTests
{
    [Test]
    public void Test1()
    {
        // Arrange
        int[] prices = { 7, 1, 5, 3, 6, 4 };

        int expected = 5;

        // Act
        var result = BestTimeToBuyAndSellStock.MaxProfit(prices);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Test2()
    {
        // Arrange
        int[] prices = { 7, 6, 4, 3, 1 };

        int expected = 0;

        // Act
        var result = BestTimeToBuyAndSellStock.MaxProfit(prices);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}