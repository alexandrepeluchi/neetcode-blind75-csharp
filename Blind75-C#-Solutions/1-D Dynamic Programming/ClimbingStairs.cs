public class Solution {
    public int ClimbStairs(int n) {     
        int a = 1;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            (a, b) = (b, a + b);
        }

        return a;
    }
}
