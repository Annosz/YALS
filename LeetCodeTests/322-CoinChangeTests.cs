using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class CoinChangeTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            int[] coins = { 1, 2, 5 };
            int amount = 11;

            int expected = 3;

            // Act
            var result = CoinChangeSolution.CoinChange(coins, amount);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            int[] coins = { 2 };
            int amount = 3;

            int expected = -1;

            // Act
            var result = CoinChangeSolution.CoinChange(coins, amount);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            // Arrange
            int[] coins = { 1 };
            int amount = 0;

            int expected = 0;

            // Act
            var result = CoinChangeSolution.CoinChange(coins, amount);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}