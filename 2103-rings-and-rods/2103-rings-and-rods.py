class Solution:
    def countPoints(self, rings: str) -> int:

        ans = 0
        i, j = 0, 1

        d = defaultdict(set)

        if(len(rings) < 2):
            return ans
        
        while i < len(rings) and j < len(rings):
            
            if not rings[i] in d[j]:

                d[rings[j]].add(rings[i])
        
            i += 2
            j += 2
        
        for v in d.values():
            if len(v) == 3:
                ans += 1
        
        return ans
        


        



        