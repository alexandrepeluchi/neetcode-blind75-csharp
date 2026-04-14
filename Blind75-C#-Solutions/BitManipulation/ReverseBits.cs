public class Solution {
    public uint ReverseBits(uint n) {
        uint result = 0;

        for (int i = 0; i < 32; i++)
        {
            uint last = n % 2;
            result = result * 2 + last;
            n = n / 2;
        }

        return result;
    }
}
