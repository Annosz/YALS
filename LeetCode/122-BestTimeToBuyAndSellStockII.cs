namespace LeetCode;

public static class BestTimeToBuyAndSellStockII
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length == 0)
            return 0;

        int minPriceSinceLastSell = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length - 1; i++)
        {
            if (prices[i] > prices[i + 1] && minPriceSinceLastSell < prices[i])
            {
                maxProfit += prices[i] - minPriceSinceLastSell;
                minPriceSinceLastSell = prices[i];
            }
            if (minPriceSinceLastSell > prices[i])
            {
                minPriceSinceLastSell = prices[i];
            }
        }

        // Chance to sell at last day
        if (minPriceSinceLastSell < prices[^1])
        {
            maxProfit += prices[^1] - minPriceSinceLastSell;
        }

        return maxProfit;
    }
}