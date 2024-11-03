/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        //if odd middle not
        // if even second middle middle ListNode

        double numOfNodes = 1;
        var currNode = head;
        

        //curr -> 1 -> 2-> 3 -> 4 -> 5 -> 6

        if(head == null) return null;

        while(currNode.next != null){

            numOfNodes += 1;
            currNode = currNode.next;

        }
        if(numOfNodes % 2 == 0) numOfNodes += 1;
        double neededNode = Math.Ceiling(numOfNodes / 2);

  
        currNode = head;
        for(int i = 1; i < neededNode; i++){
            currNode = currNode.next;
        }

        return currNode;

    }
}