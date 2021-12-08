namespace LinkedList
{
    public interface ILinkedList<T>
    {
        public Node<T>? Head { get; }
        public void AddFront(T data);
        public void AddBack(T data);
        
    }

    public class Node<T>
    {
        private T data;

        public Node<T> Prev { get; set; }
        public Node<T> Next { get; set; }
        public T Data { get { return data; } }

        public Node(T t)
        {
            data = t;
        }
    }
}