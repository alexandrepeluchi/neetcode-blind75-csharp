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
    public void ReorderList(ListNode head) {
        var list = new List<ListNode>();

        while (head != null)
        {
            list.Add(head);
            head = head.next;
        }

        int i = 0;
        int j = list.Count - 1;

        while (i < j)
        {
            list[i].next = list[j];
            i++;

            if (i == j)
                break;

            list[j].next = list[i];
            j--;
        }

        list[i].next = null;
    }
}
