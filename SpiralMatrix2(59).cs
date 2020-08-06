public class Solution {
    public int[][] GenerateMatrix(int n) {
        if (n == 0)
            return new int[1][];
        
        int[][] result = new int[n][];
        
        for (int i = 0; i < n; i++)
            result[i] = new int[n];

        DFS(result, 0, 0, new bool[n, n], 'R', n, 1);

        return result;
    }
    
    private void DFS(int[][] result, int i, int j, bool[,] visited, char direction, int n, int m)
    {
        if (m > n * n)
            return;

        result[i][j] = m;
        visited[i, j] = true;
        
        if (direction == 'R' && (j + 1 == n || visited[i, j + 1]))
            direction = 'D';
        else if (direction == 'L' && (j - 1 < 0 || visited[i, j - 1]))
            direction = 'U';
        else if (direction == 'U' && (i - 1 < 0 || visited[i - 1, j]))
            direction = 'R';
        else if (direction == 'D' && (i + 1 == n || visited[i + 1, j]))
            direction = 'L';

        if (direction == 'R')
            DFS(result, i, j + 1, visited, direction, n, m + 1);
        else if (direction == 'L')
            DFS(result, i, j - 1, visited, direction, n, m + 1);
        else if (direction == 'U')
            DFS(result, i - 1, j, visited, direction, n, m + 1);
        else if (direction == 'D')
            DFS(result, i + 1, j, visited, direction, n, m + 1);
    }
}