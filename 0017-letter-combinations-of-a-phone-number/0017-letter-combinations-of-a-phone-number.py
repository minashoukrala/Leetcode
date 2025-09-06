from collections import defaultdict
class Solution:
    def letterCombinations(self, digits: str) -> List[str]:

        ans = []
        hashset ={'2':'abc', '3':'def', '4':'ghi', '5':'jkl', '6':'mno', '7':'pqrs', '8':'tuv', '9':'wxyz' }

        if len(digits) < 1:
            return []

        self.backtrack(digits, ans, len(digits), 0, [],hashset)
        
        return ans

    
    def backtrack(self, digits, ans, l, pos, curr, hashset):

        if l == len(curr):
            ans.append("".join(curr))
            return
        
        for c in hashset[digits[pos]]:
            curr.append(c)
            self.backtrack(digits, ans, l, pos + 1, curr, hashset)
            curr.pop()
        
        return