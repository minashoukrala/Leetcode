class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        d = defaultdict(list)
        l = []
        
        for s in strs:

            d["".join(sorted(s))].append(s)

        for v in d.values():
            l.append(v)

        return l
        



