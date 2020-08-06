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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
    if(head==null || n==0) return head;
    if(head.next == null && n==1) return null; // this case had been included in below code, so it can be removed
    
   ListNode tempHead = new ListNode(0);
    tempHead.next = head;
    int count =0, index = 0;
    while(head!=null){
        count++;
        head = head.next;
    }
    
    head = tempHead;
    while(index<count-n){
        head = head.next;
        index++;
    }
    if(head.next.next!=null){
        head.next = head.next.next;
    }else{
        head.next = null;
    }
    
    return tempHead.next;
}
}