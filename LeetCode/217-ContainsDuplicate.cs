namespace LeetCode;

public static class ContainsDuplicate
{
    public static bool ContainsDuplicateX(int[] nums)
    {
        HashSet<int> elements = new HashSet<int>();
        foreach (int num in nums)
        {
            if (elements.Contains(num))
            {
                return true;
            }

            elements.Add(num);
        }
        return false;
    }
}