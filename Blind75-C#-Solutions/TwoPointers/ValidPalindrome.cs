public class Solution {
    public bool IsPalindrome(string s) {
        
        var filtered = s
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLower)
            .ToArray();

        var first = filtered;
        var last = filtered.Reverse().ToArray();

        return first.SequenceEqual(last);
    }
}
