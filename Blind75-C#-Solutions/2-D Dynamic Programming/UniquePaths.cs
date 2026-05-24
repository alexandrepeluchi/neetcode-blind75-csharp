public class Solution {
    public int UniquePaths(int m, int n) {
        int[] list = new int[n];

        Array.Fill(list, 1);

        for (int row = 1; row < m; row++)
        {
            for (int col = 1; col < n; col++)
            {
                list[col] += list[col - 1];
            }
        }

        return list[n - 1];
    }
}
