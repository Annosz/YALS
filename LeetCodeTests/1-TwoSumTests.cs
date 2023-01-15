using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class TwoSumTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] expected = { 0, 1 };

            // Act
            var result = TwoSumSolution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            int[] nums = { 3, 2, 4 };
            int target = 6;

            int[] expected = { 1, 2 };

            // Act
            var result = TwoSumSolution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            // Arrange
            int[] nums = { 3, 3 };
            int target = 6;

            int[] expected = { 0, 1 };

            // Act
            var result = TwoSumSolution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}