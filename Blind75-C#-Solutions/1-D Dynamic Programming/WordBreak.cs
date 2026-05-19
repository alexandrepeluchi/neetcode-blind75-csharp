public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        bool[] list = new bool[s.Length + 1];
        list[0] = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (!list[i]) continue;

            foreach (var word in wordDict)
            {
                if (i + word.Length <= s.Length && s.Substring(i, word.Length) == word)
                    list[i + word.Length] = true;
            }
        }

        return list[s.Length];
    }
}
