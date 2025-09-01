import math
class Solution:
    def isPowerOfTwo(self, n: int) -> bool:
        if n <= 0:
            return False

        left = 0
        right = int(math.log2(n))
        mid = 0

        
        while left <= right:
            
            mid = (left + right) // 2

            if 2**mid == n:
                return True
            
            if 2**mid > n:
                right = mid - 1
            
            else:
                left = mid + 1
            
        
        return False