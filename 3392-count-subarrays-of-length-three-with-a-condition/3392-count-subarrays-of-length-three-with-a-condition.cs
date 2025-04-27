public class Solution {
    public int CountSubarrays(int[] nums) {
        int count = 0;

        for(int i = 1; i <= nums.Length - 2; i++){
            double leftAndRight = nums[i-1] + nums[i+1];
            double mid = (double)nums[i]/2;
            if(leftAndRight==mid){
                count++;
                Console.WriteLine(leftAndRight);
                 Console.WriteLine(mid);
            }
            
        }
        return count;
    }
}