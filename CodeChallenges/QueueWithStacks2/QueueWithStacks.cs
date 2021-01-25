

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
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);
        }
        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public void Dequeue()
        {          
            while (stack1.Top != null)
            {
                stack2.Push(stack1.Top.Value);
                stack1.Pop();
            }
            stack2.Pop();
            while (stack2.Top != null)
            {
                stack1.Push(stack2.Top.Value);
                stack2.Pop();
            }
        }
    }
}

