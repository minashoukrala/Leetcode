class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        if not nums:
            return 0
        maxi = nums[0]
        curr = nums[0]

        for i in range(1, len(nums)):

            curr = max(nums[i], curr+nums[i])
            maxi = max(curr, maxi)
        return maxi
        
        