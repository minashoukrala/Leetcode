class Solution:
    def generateParenthesis(self, n: int) -> List[str]:

        opn = 0
        close = 0
        self.ans = []

        self.backtrack(opn, close, n, "")

        return self.ans

    def backtrack(self, opn, close, n, curr):

        if opn == n and close == n:
            self.ans.append(curr)
            return

        if opn < n:
            self.backtrack(opn + 1, close, n, curr + '(')

        if close < opn:
            self.backtrack(opn, close + 1, n, curr + ')') 

        return
