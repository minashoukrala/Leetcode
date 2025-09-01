class Solution:
    def climbStairs(self, n: int) -> int:

       
        self.memo = {}
        return self.recursiveCall(n, 0)

    def recursiveCall(self, n, steps):

        if steps == n:
            return 1
            
        elif steps > n:
            return 0

        if steps in self.memo:
            return self.memo[steps]
        
        self.memo[steps] = ( self.recursiveCall(n,steps + 1) + self.recursiveCall(n,steps + 2))

        return self.memo[steps]
        
            



            

        