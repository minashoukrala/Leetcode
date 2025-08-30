# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution(object):
    def reverseLL(self, newHead, newTail, beforeHead, afterTail):
        dummyCurr = newHead
        beforeCurr = None
        # reverse nodes from newHead up to (and including) newTail
        while dummyCurr != afterTail:
            temp = dummyCurr.next
            dummyCurr.next = beforeCurr
            beforeCurr = dummyCurr
            dummyCurr = temp

        # reconnect
        beforeHead.next = newTail
        newHead.next = afterTail
        return

    def reverseBetween(self, head, left, right):
        if not head or left == right:
            return head

        sentinel = ListNode(0, head)
        beforeHead = sentinel

        # move beforeHead to node just BEFORE position `left`
        for _ in range(left - 1):
            beforeHead = beforeHead.next

        newHead = beforeHead.next  # node at position `left`

        # move to node at position `right`
        newTail = newHead
        for _ in range(right - left):
            newTail = newTail.next

        afterTail = newTail.next

        self.reverseLL(newHead, newTail, beforeHead, afterTail)
        return sentinel.next
