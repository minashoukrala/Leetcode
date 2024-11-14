class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        mini=9999999999
        diff=0
        for i in range(len(prices)):
            if mini>prices[i]:
                mini=prices[i]
            
           
            if diff<(prices[i]-mini):
                diff=prices[i]-mini
               
            
        return diff    
            

        

       




