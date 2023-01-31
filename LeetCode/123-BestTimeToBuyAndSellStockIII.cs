namespace LeetCode;

public static class BestTimeToBuyAndSellStockIII
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length == 0)
            return 0;

        int minPriceSinceLastSell = prices[0];
        (int first, int second) maxProfit = (0, 0);

        for (int i = 1; i < prices.Length - 1; i++)
        {
            if (prices[i] > prices[i + 1] && minPriceSinceLastSell < prices[i])
            {
                maxProfit = SaveMaxProfit(prices[i] - minPriceSinceLastSell, maxProfit);
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
            maxProfit = SaveMaxProfit(prices[^1] - minPriceSinceLastSell, maxProfit);
        }

        return maxProfit.first + maxProfit.second;
    }

    public static (int first, int second) SaveMaxProfit(int newProfit, (int first, int second) maxProfit)
    {
        if (newProfit >= maxProfit.first)
        {
            maxProfit.second = maxProfit.first;
            maxProfit.first = newProfit;
        }
        else if (newProfit >= maxProfit.second)
        {
            maxProfit.second = newProfit;
        }

        return maxProfit;
    }
}