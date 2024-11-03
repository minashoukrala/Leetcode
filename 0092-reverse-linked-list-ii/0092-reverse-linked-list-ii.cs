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
    public ListNode ReverseBetween(ListNode head, int left, int right) {

       if (left == right || head == null || head.next == null) return head;

        // Create a dummy node to handle edge cases where the reversal starts at the head
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;

        // Move `prev` to the node just before the `left` position
        for (int i = 1; i < left; i++) {
            prev = prev.next;
        }

        // `start` is the first node in the sublist to be reversed
        ListNode start = prev.next;
        ListNode nodeToReverse = start.next;

        // Reverse the sublist between `left` and `right`
        for (int i = 0; i < right - left; i++) {
            start.next = nodeToReverse.next;
            nodeToReverse.next = prev.next;
            prev.next = nodeToReverse;
            nodeToReverse = start.next;
        }

        return dummy.next;
}
}