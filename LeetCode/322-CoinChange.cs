namespace LeetCode;

public static class CoinChangeSolution
{
    public static int CoinChange(int[] coins, int amount)
    {
        int[] possibleValues = Enumerable.Repeat(-1, amount + 1).ToArray();
        possibleValues[0] = 0;

        foreach (int coin in coins.Where(c => c <= amount).OrderByDescending(c => c))
        {
            possibleValues[coin] = 1;
            for (int i = coin; i <= amount - coin; i++)
            {
                if (possibleValues[i] != -1 && (possibleValues[i + coin] == -1 || possibleValues[i + coin] > possibleValues[i] + 1))
                {
                    possibleValues[i + coin] = possibleValues[i] + 1;
                }
            }
        }

        return possibleValues[amount];
    }
}