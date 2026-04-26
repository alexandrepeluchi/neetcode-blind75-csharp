public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        int left = 0;
        int max = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while(set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);
            max = Math.Max(max, right - left + 1);
        }

        return max;
    }
}
