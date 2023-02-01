namespace LeetCode;

public static class ContainsDuplicateII
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> elements = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (elements.ContainsKey(nums[i]) && Math.Abs(elements[nums[i]] - i) <= k)
            {
                return true;
            }

            elements[nums[i]] = i;
        }

        return false;
    }
}