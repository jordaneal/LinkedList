namespace Neal_LinkedList
{
    class LinkedList
    {
        public Node Add(Node head, Node newNode)
        {
            if (head == null)
                return newNode;

            Node current = head;

            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = newNode;
                    return head;
                }
                else
                    current = current.Next;
            };
            return head;
        }
        public Node Contains(Node head, string item)
        {
            if (head == null)
                return null;

            Node current = head;

            while (current != null)
            {
                if (current.Data.ToLower() == item.ToLower())
                    return current;
                else
                    current = current.Next;
            };
            return null;
        }
        public Node Remove(Node head, string item)
        {
            if (head.Data.ToLower() == item.ToLower() && head.Next == null)
            {
                head = null;
                return head;
            }
            else if (head.Data.ToLower() == item.ToLower())
            {
                head = head.Next;
                return head;
            }

            Node current = head;

            while (current.Next != null)
            {
                if (current.Next.Data.ToLower() == item.ToLower() && current.Next.Next == null)
                {
                    current.Next = null;
                    return head;
                }
                else if (current.Next.Data.ToLower() == item.ToLower())
                {
                    current.Next = current.Next.Next;
                    return head;
                }
                else
                    current = current.Next;
            };
            return head;
        }
        public string PrintAllNodes(Node head)
        {
            if (head == null)
                return "ALERT: LINKED LIST IS EMPTY";

            Node current = head;
            string allNodeData = "- " + current.Data;

            while (current.Next != null)
            {
                current = current.Next;
                allNodeData += $"\n- {current.Data}";
            };
            return allNodeData;
        }
    }
}