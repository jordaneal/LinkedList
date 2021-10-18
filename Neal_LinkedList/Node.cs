namespace Neal_LinkedList
{
    class Node
    {
        private string _data;
        private Node _next;
        public Node(string data)
        {
            _data = data;
        }
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
