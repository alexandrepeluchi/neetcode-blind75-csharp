public class Solution {
    public string LongestPalindrome(string s) {
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            Check(i, i);
            Check(i, i + 1);
        }

        void Check(int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > result.Length)
                    result = s.Substring(left, right - left + 1);

                left--;
                right++;
            }
        }

        return result;
    }
}
