using System.Collections.Generic;


namespace QueueWithStacks
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

        public void Dequeue()
        {
            while (stack1 != null)
            {
                stack2.Push(stack1.Top);
                stack1.Pop();
            }
            stack2.Pop();

            while (stack2.Top != null)
            {
                stack1.Push(stack2.Top);
                stack2.Pop();
            }
        }
    }
}