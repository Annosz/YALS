namespace LeetCode
{
    public static class AddTwoNumbersSolution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int currentCarryOver = 0)
        {
            int currentSum = l1.val + l2.val + currentCarryOver;
            int nextCarryOver = currentSum / 10;

            ListNode? nextSum = null;
            if (!(l1.next == null && l2.next == null))
                nextSum = AddTwoNumbers(l1.next ?? new ListNode(), l2.next ?? new ListNode(), nextCarryOver);

            if (nextSum == null && nextCarryOver != 0)
                nextSum = new ListNode(nextCarryOver, null);

            return new ListNode(currentSum % 10, nextSum);
        }

        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
