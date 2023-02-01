namespace LeetCode;

public static class ContainsDuplicateIII
{
    public static bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        SortedSet<int> numbersWithinIndexDiff = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numbersWithinIndexDiff.GetViewBetween(nums[i] - valueDiff, nums[i] + valueDiff).Any())
                return true;

            numbersWithinIndexDiff.Add(nums[i]);

            // We can safely remove the element, if it would be a duplicate, we would be already returning true
            if (i >= indexDiff)
                numbersWithinIndexDiff.Remove(nums[i - indexDiff]);
        }

        return false;
    }
}