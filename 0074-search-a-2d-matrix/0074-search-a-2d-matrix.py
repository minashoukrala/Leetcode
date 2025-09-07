class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        row = len(matrix) - 1
        col = 0
        seen=set()

        while col < len(matrix[0]) and row >= 0:
            if (row, col) in seen:
                return False
            seen.add((row,col))
            if target > matrix[row][col]:
                col += 1
            elif matrix[row][col]> target:
                row -= 1
            else:
                return True
        return False
        