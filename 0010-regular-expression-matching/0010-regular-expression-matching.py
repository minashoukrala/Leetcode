class Solution:
    def isMatch(self, s: str, p: str) -> bool:
        
        lenS = len(s)
        lenP = len(p)
        i, j = 0, 0

        return self.backtrack(lenS, lenP, i, j, s, p)


    def backtrack(self, lenS, lenP, i, j, s, p):

        if j == lenP:
            return i == lenS
        
        
        
        if j + 1 < lenP and p[j + 1] == '*':
        # option 1: skip "x*" entirely
            if self.backtrack(lenS, lenP, i, j + 2, s, p):
                return True
        # option 2: use one "x" if it matches
            if i < lenS and (p[j] == s[i] or p[j] == '.'):
                return self.backtrack(lenS, lenP, i + 1, j, s, p)
            return False
        if i< lenS and s[i] == p[j] or p[j] =='.':
            return self.backtrack(lenS, lenP, i + 1, j + 1, s, p)

        return False

        

