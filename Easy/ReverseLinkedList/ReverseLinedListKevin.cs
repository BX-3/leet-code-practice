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
    public bool isFirst = true;
    
    var node = new ListNode();
    
    public ListNode ReverseList(ListNode head) {
        
        while(head.next != null){
            
            if(isFirst){
                isFirst = false;
                node = new ListNode(head.val, null);
            }else{
                node = new ListNode(head.val, node);
            }
            
            head = head.next;
        }
        
        return new ListNode(head.val, node);
            
      
    }

    public ListNode RecursiveReverse(ListNode head){
       //TODO
    }
}