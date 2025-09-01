class Solution:
    def mySqrt(self, x: int) -> int:
        
        left= x//2 + 1
        right = 0
        mid = 0

        if(x < 2):
            return x

        while left >= right:
            mid = (left + right) // 2

            if mid*mid == x:
                return mid

            elif mid*mid > x:
                left = mid - 1

            else:
                right = mid + 1

        return left
            
            
