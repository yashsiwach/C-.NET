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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode first=new ListNode();
        ListNode second=new ListNode();
        ListNode ans=new ListNode();
        ListNode curr=ans;
        first=list1;
        second=list2;
        while(first!=null&&second!=null){
            if(first.val<second.val){
                curr.next=first;
                first=first.next;
            }else{
                curr.next=second;
                second=second.next;
            }
            curr=curr.next;
        }
        while(first!=null){
            curr.next=first;
                first=first.next;
            curr=curr.next;

        }
        while(second!=null){
                curr.next=second;

                second=second.next;
                            curr=curr.next;

        }
        return ans.next;
    }
}