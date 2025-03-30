public class Solution {
    public int DeleteGreatestValue(int[][] grid) {

       for (int i = 0; i < grid.Length; i++)
            Array.Sort(grid[i]);
        
        int res = 0;
        for (int i = grid[0].Length - 1; 0 <= i; i--)
        {
            int tmp = 0;
            for (int j = 0; j < grid.Length; j++)
                tmp = Math.Max(tmp, grid[j][i]);
            res += tmp;
        }
        return res;
        
    }
}