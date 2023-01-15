namespace LeetCode;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        int longestSubstringLength = 0;

        int startIndex = 0;
        int endIndex = 1;

        while (endIndex <= s.Length)
        {
            string segment = s[startIndex..endIndex];
            if (segment.ToHashSet().Count == segment.Length)
            {
                longestSubstringLength = longestSubstringLength > segment.Length ? longestSubstringLength : segment.Length;
                endIndex++;
            }
            else
            {
                startIndex++;
            }

        }

        return longestSubstringLength;
    }
}