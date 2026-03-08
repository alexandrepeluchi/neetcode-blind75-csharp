public class Solution {
    public bool IsAnagram(string s, string t) {
        
        // Return false if lenght are different
        if (s.Length != t.Length)
            return false;

        // Check if are an Anagram
        char[] sOrder = s.ToCharArray();
        char[] tOrder = t.ToCharArray();

        Array.Sort(sOrder);
        Array.Sort(tOrder);

        // Return the result
        return sOrder.SequenceEqual(tOrder);
    }
}
