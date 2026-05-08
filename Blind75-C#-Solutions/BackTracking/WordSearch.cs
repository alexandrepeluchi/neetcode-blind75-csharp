public class Solution {
    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int cols = board[0].Length;

        bool DFS(int row, int col, int i)
        {
            if (i == word.Length) 
                return true;

            if (row < 0 || col < 0 || row >= rows || col >= cols || board[row][col] != word[i])
                return false;

            char aux = board[row][col];
            board[row][col] = '#';

            bool found = 
                DFS(row + 1, col, i + 1) ||
                DFS(row - 1, col, i + 1) ||
                DFS(row, col + 1, i + 1) ||
                DFS(row, col - 1, i + 1);

            board[row][col] = aux;
            return found;
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (DFS(row, col, 0))
                    return true;
            }
        }

        return false;
    }
}
