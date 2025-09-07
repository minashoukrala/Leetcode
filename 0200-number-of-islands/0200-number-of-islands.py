class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:

        def valid(row, col):
            return 0 <= row < len(grid) and 0 <= col < len(grid[0]) and grid[row][col] == "1"

        def dfs(row, col, directions, seen):

            for d in directions:
                (x, y) = d

                if valid(row + x, col + y) and (row + x, col + y) not in seen:
                    seen.add((row + x, col + y)) 
                    dfs(row + x, col + y, directions, seen)
            return 

        seen = set()
        ans = 0
        directions = [(0,1), (0, -1), (1, 0), (-1, 0)]
        for i in range(len(grid)):
            for j in range(len(grid[0])):
                if (i, j)not in seen and valid(i,j):
                    seen.add((i, j))
                    ans += 1
                    dfs(i, j, directions, seen)
        return ans


        
    
    
    

        