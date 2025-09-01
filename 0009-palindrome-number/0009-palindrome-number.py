class Solution:
    def isPalindrome(self, x: int) -> bool:
    
        if x < 0:
            return False

        xCopy = x
        ans = 0
        
        while xCopy > 0:
            
            ans = (ans * 10) + int(xCopy%10)
            print(ans)

            xCopy =int(xCopy/10)

        return x == ans



        
    


