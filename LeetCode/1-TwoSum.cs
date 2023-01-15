namespace LeetCode
{
    public static class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new();
            for (var i = 0; i < nums.Length; i++)
            {
                var complementer = target - nums[i];
                if (map.ContainsKey(complementer))
                    return new[] { map[complementer], i };
                map[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}