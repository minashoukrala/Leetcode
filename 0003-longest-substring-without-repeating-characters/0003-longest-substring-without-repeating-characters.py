class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """

        seen = set()
        i = j = 0
        best = 0
        while j < len(s):
            if s[j] not in seen:          # expand window
                seen.add(s[j])
                j += 1
                best = max(best, j - i)
            else:                         # shrink from left
                seen.remove(s[i])
                i += 1
        return best
                



            

            
            


        
        