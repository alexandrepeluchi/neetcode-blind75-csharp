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
    public ListNode ReverseList(ListNode head) {
        
        if (head == null)
            return null;

        ListNode anterior = null;
        ListNode atual = head;

        while (atual != null)
        {
            ListNode aux = atual.next;
            atual.next = anterior;
            anterior = atual;
            atual = aux;
        }

        return anterior;

    }
}