public class Solution {
    public int CountSubstrings(string s) {
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            Count(i, i);
            Count(i, i + 1);
        }

        void Count(int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++;;
                left--;
                right++;
            }
        }

        return count;
    }
}
