namespace LeetCode;

public static class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        if (x == 0)
            return true;

        int originalNumber = x;
        int reversedNumber = 0;

        while (x > 0)
        {
            reversedNumber = 10 * reversedNumber + x % 10;
            x /= 10;
        }

        return originalNumber == reversedNumber;
    }
}