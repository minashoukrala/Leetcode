class Solution:
    def isHappy(self, n: int) -> bool:

        seen = set()

        while n > 1:

            newN = 0
            tempN = n

            if(n in seen):
                return False
            seen.add(n)

            while(tempN > 0):
                remainder = tempN % 10
                newN = newN + remainder * remainder
               
                tempN //= 10
                print(newN)

            
            n = newN

        return n == 1
        
