namespace DataStructures
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Rear { get; set; }


        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Front == null) { Front = newNode; Rear = newNode; }
            //else if (Front.Next == null) { Front.Next = newNode; }
            Rear.Next = newNode;
            Rear = newNode;
        }

        public void Dequeue()
        {
            Node<T> tempNode = Front.Next;
            Front = tempNode;
        }
        public T Peek()
        {
            return Front.Value;
        }

        public bool IsEmpty()
        {
            if (Front != null) return false;
            return true;
        }

    }

}
