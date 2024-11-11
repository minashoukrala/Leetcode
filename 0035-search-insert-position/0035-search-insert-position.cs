public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int start = 0, end = nums.Length - 1;
        int mid = 0;

        if(end < 0 ) return 0;

        while(start <= end){
            mid = (start + end) / 2;

            if(nums[mid] == target) return mid;

            else if(nums[mid] > target){
                end = mid - 1;
            }else if(nums[mid] < target){
                start = mid + 1;
            }

        }
        return mid + 1;
    }
}