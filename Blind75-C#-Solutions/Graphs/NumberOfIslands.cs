public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;

        void DFS(int row, int col)
        {
            if (row < 0 || col < 0 || row >= rows || col >= cols || grid[row][col] == '0')
                return;

            grid[row][col] = '0';

            DFS(row + 1, col);
            DFS(row - 1, col);
            DFS(row, col + 1);
            DFS(row, col -1);
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (grid[row][col] == '1')
                {
                    islands++;
                    DFS(row, col);
                }
            }
        }

        return islands;
    }
}
