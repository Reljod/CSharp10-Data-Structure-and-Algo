namespace LinkedList
{
    public class SimpleLinkedList<T> : ILinkedList<T>
    {
        private Node<T>? head;
        public Node<T>? Head {
            get { return head; }
        }

        internal Node<T> getLatestNode()
        {
            var currentNode = head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public void AddFront(T data)
        {
            var newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> latestNode = getLatestNode();
            latestNode.Next = newNode;
        }

        public void AddBack(T data)
        {
            var newNode = new Node<T>(data);

            newNode.Next = head;
            head = newNode;
        }
    }
}