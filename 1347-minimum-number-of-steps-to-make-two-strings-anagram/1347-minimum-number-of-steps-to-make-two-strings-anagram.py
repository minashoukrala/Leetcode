class Solution:
    def minSteps(self, s: str, t: str) -> int:
        d = Counter()
        ans = 0

        if len(s) != len(t):
            return -1

        for c in s:
            d[c] += 1
        
        for c in t:
            d[c] -= 1
        
        for v in d.values():
            if v > 0:
                ans += v

        return ans

