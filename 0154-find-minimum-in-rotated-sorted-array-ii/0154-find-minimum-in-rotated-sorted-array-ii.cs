public class Solution {
    public int FindMin(int[] nums) {

         int len = nums.Length;
        if(len <= 2){
            if(len == 1)
                return nums[0];
            return Math.Min(nums[0],nums[1]);
        }

        int mid= (len) / 2;
        int left = mid;
        int right = mid;

        while(left >= 0 || right < len){
            if(left >= 0 && nums[left + 1] < nums[left])
                return nums[left + 1];
            if(right <len && nums[right] < nums[right - 1])
                return nums[right];
            
            
            left = left - 1;
            right = right + 1;
        }
        return nums[0];
    }
}