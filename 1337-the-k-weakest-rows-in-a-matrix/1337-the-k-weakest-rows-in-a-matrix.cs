public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {

        PriorityQueue<int ,(int sum, int index)> maxHeap = new PriorityQueue<int , (int sum, int index) >();

        for(int index = 0; index < mat.Length; index++){
            int soldierCount = mat[index].Sum();
            maxHeap.Enqueue(index, (soldierCount,index));
        }

        int[] ans = new int[k];

        for(int i = 0; i < k; i++){
            ans[i] = maxHeap.Dequeue();
        }

        return ans;
        
    }
}