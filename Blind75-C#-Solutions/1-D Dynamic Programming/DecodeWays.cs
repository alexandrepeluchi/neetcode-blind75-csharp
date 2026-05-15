public class Solution {
    public int NumDecodings(string s) {
        if (s[0] == '0')
            return 0;

        int aux = 1;
        int auxBefore = 1;

        for (int i = 1; i < s.Length; i++)
        {
            int curr = 0;

            if (s[i] != '0')
                curr += aux;

            int twoDig = (s[i - 1] - '0') * 10 + (s[i] - '0');

            if (twoDig >= 10 && twoDig <= 26)
                curr += auxBefore;

            auxBefore = aux;
            aux = curr;
        }

        return aux;
    }
}
