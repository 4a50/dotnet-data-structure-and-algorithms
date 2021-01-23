namespace DataStructures
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }


        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (Front == null) { Front = newNode; Rear = newNode; }
            //else if (Front.Next == null) { Front.Next = newNode; }
            Rear.Next = newNode;
            Rear = newNode;
        }

        public void Dequeue()
        {
            Node tempNode = Front.Next;
            Front = tempNode;
        }        
        public int Peek()
        {
            return Front.Value;
        }

        public bool isEmpty()
        {
            if (Front != null) return false;
            return true;
        }

    }

}
