namespace LeetCode;

public static class BestTimeToBuyAndSellStock
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length == 0)
            return 0;

        int minPriceSoFar = prices[0];
        int maxProfitSoFar = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (maxProfitSoFar < prices[i] - minPriceSoFar)
            {
                maxProfitSoFar = prices[i] - minPriceSoFar;
            }
            if (minPriceSoFar > prices[i])
            {
                minPriceSoFar = prices[i];
            }
        }

        return maxProfitSoFar;
    }
}