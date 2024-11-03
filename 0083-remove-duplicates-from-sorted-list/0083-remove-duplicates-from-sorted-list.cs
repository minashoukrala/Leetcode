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
    public ListNode DeleteDuplicates(ListNode head) {
        // list is empty 
        // hold prev and head and move comparing
        //if duplicate prev.next = head.next


        if(head == null || head.next == null) return head;

        var curr = head;

        while(curr != null && curr.next != null){
            if(curr.val == curr.next.val){
                curr.next = curr.next.next;
            }

            else curr = curr.next;
        }
        return head;
        



    }
}