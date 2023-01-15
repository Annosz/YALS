using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class AddTwoNumbersTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            AddTwoNumbersSolution.ListNode l1 =
                new AddTwoNumbersSolution.ListNode(2,
                    new AddTwoNumbersSolution.ListNode(4,
                        new AddTwoNumbersSolution.ListNode(3)));
            AddTwoNumbersSolution.ListNode l2 =
                new AddTwoNumbersSolution.ListNode(5,
                    new AddTwoNumbersSolution.ListNode(6,
                        new AddTwoNumbersSolution.ListNode(4)));

            AddTwoNumbersSolution.ListNode expected =
                new AddTwoNumbersSolution.ListNode(7,
                    new AddTwoNumbersSolution.ListNode(0,
                        new AddTwoNumbersSolution.ListNode(8)));

            // Act
            var result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);

            // Assert
            Check(result, expected);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            AddTwoNumbersSolution.ListNode l1 =
                new AddTwoNumbersSolution.ListNode(0);
            AddTwoNumbersSolution.ListNode l2 =
                new AddTwoNumbersSolution.ListNode(0);

            AddTwoNumbersSolution.ListNode expected =
                new AddTwoNumbersSolution.ListNode(0);

            // Act
            var result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);

            // Assert
            Check(result, expected);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            AddTwoNumbersSolution.ListNode l1 =
                new AddTwoNumbersSolution.ListNode(9,
                    new AddTwoNumbersSolution.ListNode(9,
                        new AddTwoNumbersSolution.ListNode(9,
                            new AddTwoNumbersSolution.ListNode(9,
                                new AddTwoNumbersSolution.ListNode(9,
                                    new AddTwoNumbersSolution.ListNode(9,
                                        new AddTwoNumbersSolution.ListNode(9)))))));
            AddTwoNumbersSolution.ListNode l2 =
                new AddTwoNumbersSolution.ListNode(9,
                    new AddTwoNumbersSolution.ListNode(9,
                        new AddTwoNumbersSolution.ListNode(9,
                            new AddTwoNumbersSolution.ListNode(9))));

            AddTwoNumbersSolution.ListNode expected =
                new AddTwoNumbersSolution.ListNode(8,
                    new AddTwoNumbersSolution.ListNode(9,
                        new AddTwoNumbersSolution.ListNode(9,
                            new AddTwoNumbersSolution.ListNode(9,
                                new AddTwoNumbersSolution.ListNode(0,
                                    new AddTwoNumbersSolution.ListNode(0,
                                        new AddTwoNumbersSolution.ListNode(0,
                                            new AddTwoNumbersSolution.ListNode(1))))))));

            // Act
            var result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);

            // Assert
            Check(result, expected);
        }

        private void Check(AddTwoNumbersSolution.ListNode? actual, AddTwoNumbersSolution.ListNode? expected)
        {
            if (actual is null && expected is null)
                return;

            Assert.That(actual?.val, Is.EqualTo(expected?.val));

            Check(actual?.next, expected?.next);
        }
    }
}
