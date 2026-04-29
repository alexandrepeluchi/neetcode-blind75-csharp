public class Solution {
    public int CharacterReplacement(string s, int k) {
        string str = s;
        int num = k;

        int[] count = new int[26];
        int left = 0;
        int maxFreq = 0;
        int result = 0;

        for (int right = 0; right < s.Length; right++)
        {
            int aux = str[right] - 'A';
            count[aux]++;

            maxFreq = Math.Max(maxFreq, count[aux]);

            while ((right - left + 1) - maxFreq > num)
            {
                count[str[left] - 'A']--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
