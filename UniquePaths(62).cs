public class Solution {
    public int UniquePaths(int m, int n) {
    int[,] path = new int[m, n];
    for(int i = 0; i < path.GetLength(0); i++)
        for(int j = 0; j < path.GetLength(1); j++){
            int up = i == 0 ? 0 : path[i - 1, j], left = j == 0 ? 0 : path[i, j - 1];
            path[i, j] = up + left != 0 ? up + left : 1;
        }
    return path[m - 1, n - 1];
}
}