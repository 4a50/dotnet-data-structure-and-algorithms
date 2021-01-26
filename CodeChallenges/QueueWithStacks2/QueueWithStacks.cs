

using System;

namespace DataStructures
{
    public class QueueWithStacks
    {
        public Stack<int> stack1 { get; set; }
        public Stack<int> stack2 { get; set; }

        public QueueWithStacks()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();            
        }
        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int Dequeue()
        {
            if (stack1.Top == null) { return -1; }
            int valPopped = 0;
            while (stack1.Top != null)
            {   
                stack2.Push(stack1.Top.Value);
                stack1.Pop();             
            }
            stack2.Pop();            
            valPopped = stack2.Top.Value;
            while (stack2.Top != null)
            {
                stack1.Push(stack2.Top.Value);
                stack2.Pop();
            }
            return valPopped;
        }
    }
}

