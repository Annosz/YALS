namespace LeetCode;

public static class ProductOfArrayExceptSelf
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] leftProducts = GenerateLeftProducts(nums);
        int[] rightProducts = GenerateRightProducts(nums);

        return nums.Select((_, i) => leftProducts[i] * rightProducts[i]).ToArray();
    }

    private static int[] GenerateLeftProducts(int[] nums)
    {
        List<int> leftProducts = new() { 1 };
        for (int i = 1; i < nums.Length; i++)
        {
            leftProducts.Add(leftProducts[i - 1] * nums[i - 1]);
        }

        return leftProducts.ToArray();
    }

    private static int[] GenerateRightProducts(int[] nums)
    {
        List<int> leftProducts = new() { 1 };
        for (int i = 1; i < nums.Length; i++)
        {
            leftProducts.Insert(0, leftProducts[^i] * nums[^i]);
        }
        return leftProducts.ToArray();
    }
}