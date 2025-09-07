class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        mini=9999999999
        diff=0
        for i in range(len(prices)):
            mini = min(mini, prices[i])
            
           
            diff = max(diff, prices[i] - mini)
               
            
        return diff    
            

        

       




