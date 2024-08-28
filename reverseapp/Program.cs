namespace reverseapp
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {
                ListNode prev = null;
                ListNode current = head;
                ListNode nextNode = null;

                while (current != null)
                {
                    nextNode = current.next;
                    current.next = prev;
                    prev = current;
                    current = nextNode;
                }

                return prev;
            }
        }

        static void Main(string[] args)
         {
            
            ListNode head = new ListNode(15, new ListNode(30, new ListNode(45, new ListNode(60, new ListNode(75)))));

            Solution solution = new Solution();
            ListNode reversedHead = solution.ReverseList(head);

            PrintList(reversedHead);
        }

        static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}    
