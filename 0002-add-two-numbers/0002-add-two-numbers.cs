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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode dummyHead = new ListNode(-1);
            ListNode head = dummyHead;
            int carry = 0;


            while(l1 != null && l2 != null){
                int sum = l1.val + l2.val + carry;
                if(sum > 9){
                    head.next = new ListNode(sum%10);
                    sum /= 10;
                    carry = sum;
                }

                else{
                    head.next = new ListNode(sum);
                    carry = 0;
                }

                l1 = l1.next;
                l2 = l2.next;
                head = head.next;
            }

            while(l1 != null){

                int sum = l1.val + carry;

                if(sum > 9){
                    head.next = new ListNode(sum%10);
                    sum /= 10;
                    carry = sum;
                    l1 = l1.next;
                }

                else{
                    head.next = new ListNode(sum);
                    l1 = l1.next;
                    carry = 0;
                }
                head = head.next;

            }
            while(l2 != null){

                int sum = l2.val + carry;

                if(sum > 9){
                    head.next = new ListNode(sum%10);
                    sum /= 10;
                    head = head.next;
                    carry = sum;
                    l2 = l2.next;
                }

                else{
                    head.next = new ListNode(sum);
                    head = head.next;
                    l2 = l2.next;
                    carry = 0;
                }

            }

            if(carry != 0){
                head.next = new ListNode(carry);
            }

            return dummyHead.next;
      
             
    }
}