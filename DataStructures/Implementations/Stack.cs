namespace DataStructures
{
    public class Stack
    {
        public Node Top { get; set; }
        /// <summary>
        /// Add a node to a stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Top;
            Top = newNode;
        }
        /// <summary>
        /// Remove most recent node from the stack.  
        /// </summary>
        public void Pop()
        {
            Node tempNode = Top.Next;
            Top = tempNode;
        }
        /// <summary>
        /// Output the value of the node on top of the Stack.  If empty NullReference Exception
        /// will be raised.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return Top.Value;
        }
        /// <summary>
        /// Return a boolean on the current state of the stack.
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (Top != null) return false;
            return true;
        }
    }
}
