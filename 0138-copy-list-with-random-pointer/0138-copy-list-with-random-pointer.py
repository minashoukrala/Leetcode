"""
# Definition for a Node.
class Node:
    def __init__(self, x: int, next: 'Node' = None, random: 'Node' = None):
        self.val = int(x)
        self.next = next
        self.random = random
"""

class Solution:
    def copyRandomList(self, head: 'Optional[Node]') -> 'Optional[Node]':
      
       
        hashmap = {}
        dummy = head

        while dummy:
            
            newNode = Node(dummy.val, None, None)
            hashmap[dummy] = newNode
            dummy = dummy.next
        
        for (k, v) in hashmap.items():
            if k.next:
                v.next = hashmap[k.next]
            if k.random:
                v.random = hashmap[k.random]
        
        newH = hashmap.get(head)
        
        return newH
            
        